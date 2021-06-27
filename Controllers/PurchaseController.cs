using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EF;
using WebApp.EntityModels;
using WebApp.Helper;
using WebApp.ViewModels.Program;
using WebApp.ViewModels.Purchase;
using static WebApp.Helper.Autorization;

namespace WebApp.Controllers
{
    [Autorization(true, true)]
    public class PurchaseController : Controller
    {
        MyContext _context;

        public PurchaseController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var loggedUserAccount = HttpContext.GetLoggedUser();
            var loggedUser = _context.User.Where(w => w.UserAccountId == loggedUserAccount.Id).FirstOrDefault();

            var purchases = _context.PurchaseParticipants
                                .Where(w => w.ParticipantId == loggedUser.Id)
                                .Select(s => new GetPurchases_VM
                                {
                                    Id = s.PurchaseId,
                                    Created = s.Purchase.DateCreated,
                                    Creator = s.Purchase.Creator.Name + " " + s.Purchase.Creator.Surname,
                                    ProgramTitle = s.Purchase.Program.Name,
                                    Participants = _context.PurchaseParticipants.Where(w => w.PurchaseId == s.PurchaseId).Count()
                                })
                                .ToList();
            return View(purchases);
        }

        public IActionResult GetProgramPurchasesDetails(int PurchaseId)
        {
            var model = _context.Purchase.Where(w => w.Id == PurchaseId).Select(s => new GetProgramPurchasesDetails_VM
            {
                PurchaseId = s.Id,
                ProgramId = s.ProgramId,
                Creator = s.Creator.Name + " " + s.Creator.Surname,
                DateCreated = s.DateCreated,
                ProgramName = s.Program.Name,
                Participants = _context.PurchaseParticipants.Where(w => w.PurchaseId == s.Id).Select(x => new GetProgramPurchasesDetails_VM.Participant
                {
                    Age = x.Participant.Age,
                    City = x.Participant.City,
                    Country = x.Participant.Country,
                    Name = x.Participant.Name,
                    ParticipantId = x.ParticipantId,
                    Arrival = x.Arrival,
                    Group = x.ParticipantGroup
                })
                .OrderBy(o => o.Group)
                .ToList(),
                InvoiceId = _context.Invoice.Where(w => w.PurchaseId == PurchaseId).Select(x => x.Id).FirstOrDefault()
            }).FirstOrDefault();
            return View(model);
        }

        public IActionResult PurchaseProgram()
        {
            var loggedUserAccount = HttpContext.GetLoggedUser();
            var loggedUser = _context.User.Where(w => w.UserAccountId == loggedUserAccount.Id).FirstOrDefault();
            var model = _context.Program.Where(w => w.ProgramState == ProgramState.Approved).Select(s => new GetAvailablePrograms_VM
            {
                Id = s.Id,
                Title = s.Name,
                Description = s.Description,
                CreatedByMe = s.CreatorId == loggedUser.Id,
                NumberOfSells = _context.Purchase.Where(w => w.ProgramId == s.Id).Count(),
                NumberOfCustomersPurcheses = _context.PurchaseParticipants.Where(w => w.Purchase.ProgramId == s.Id).Count(),
                ExpectedPrice = _context.ProgramActivityAttachment.Where(w => w.ProgramActivity.ProgramId == s.Id).Sum(s => s.ActivityAttachment.PriceToVisit)
            }).ToList();
            return View(model);
        }

        public async Task<IActionResult> OrderProgram(int ProgramId)
        {
            var loggedUserAccount = HttpContext.GetLoggedUser();
            var loggedUser = await _context.User.Where(w => w.UserAccountId == loggedUserAccount.Id).FirstOrDefaultAsync();
            var program = await _context.Program.Where(w => w.Id == ProgramId).FirstOrDefaultAsync();
            if (program.ProgramState == ProgramState.Approved)
            {
                if (program.ProgramAccess == ProgramAccess.Private)
                {
                    if (program.Creator.Id != loggedUser.Id)
                        return RedirectToAction("PurchaseProgram");
                }

                var purchase = new Purchase
                {
                    DateCreated = DateTime.Now,
                    ProgramId = ProgramId,
                    CreatorId = loggedUser.Id
                };
                _context.Purchase.Add(purchase);
                await _context.SaveChangesAsync();
                var purchaseparticipant = new PurchaseParticipants
                {
                    ParticipantId = loggedUser.Id,
                    PurchaseId = purchase.Id,
                    Arrival = DateTime.Now,
                    ParticipantGroup = 1
                };
                _context.PurchaseParticipants.Add(purchaseparticipant);
                await _context.SaveChangesAsync();
                return RedirectToAction("GetProgramPurchasesDetails", new { PurchaseId = purchase.Id });
            }
            else
                return RedirectToAction("PurchaseProgram");

        }

        public async Task<IActionResult> AddUserToPurchase(int PurchaseId, int UserId)
        {
            var purchase = await _context.Purchase.Where(w => w.Id == PurchaseId).FirstOrDefaultAsync();
            var purchaseparticipant = await _context.PurchaseParticipants.Where(w => w.PurchaseId == PurchaseId && w.ParticipantId == UserId).FirstOrDefaultAsync();
            if (purchase != null && purchaseparticipant == null)
            {
                var participant = new PurchaseParticipants
                {
                    PurchaseId = PurchaseId,
                    ParticipantId = UserId,
                    Arrival = purchase.DateCreated,
                    ParticipantGroup = 1
                };
                _context.PurchaseParticipants.Add(participant);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("GetProgramPurchasesDetails", new
            {
                PurchaseId = PurchaseId
            });
        }

        public async Task<IActionResult> RemoveUserFromPurchase(int PurchaseId, int UserId)
        {
            var participant = await _context.PurchaseParticipants.Include(i => i.Purchase).Where(w => w.PurchaseId == PurchaseId && w.ParticipantId == UserId).FirstOrDefaultAsync();
            if (participant == null)
                return StatusCode(400);
            _context.PurchaseParticipants.Remove(participant);
            await _context.SaveChangesAsync();

            var ProgramId = participant.Purchase.ProgramId;
            return RedirectToAction("GetProgramPurchasesDetails", new
            {
                PurchaseId = PurchaseId
            });
        }


        public IActionResult GetUsersToAddToPurchase(int PurchaseId, string SearchValue)
        {
            var model = new AddUserToPurchase_VM { PurchaseId = PurchaseId };
            model.Users = _context.User.Where(w => w.Name.Contains(SearchValue) || w.Surname.Contains(SearchValue)).Select(s => new AddUserToPurchase_VM.User
            {
                Id = s.Id,
                Name = s.Name + " " + s.Surname
            }).ToList();
            return PartialView(model);
        }

        [Autorization(false, true)]
        public IActionResult GetInvoices()
        {
            var inv = _context.Invoice
                        .Select(s => new GetInvoices_VM
                        {
                            Id = s.Id,
                            Customer = s.Customer,
                            CustomerCountry = s.CustomerCountry,
                            DateOfIssue = s.DateOfIssue,
                            PlaceOfIssue = s.PlaceOfIssue,
                            Settled = s.SettledInBAM
                        })
                        .ToList();
            return View(inv);
        }

        [Autorization(true, true)]
        public IActionResult IssueAnInvoice(int InvoiceId)
        {
            var inv = _context.Invoice.Where(w => w.Id == InvoiceId).FirstOrDefault();
            var m = new IssueAnInvoice_VM
            {
                Invoice = inv,
                Table = _context.InvoiceTable
                                    .Where(w => w.InvoiceId == inv.Id)
                                    .Select(s => new IssueAnInvoice_VM.TableContent
                                    {
                                        Column = s.Column,
                                        Row = s.Row,
                                        Value = s.Value
                                    }).ToList()
            };


            return View(m);
        }

        [Autorization(false, true)]
        public IActionResult ModifyInvoice(int InvoiceId)
        {
            return RedirectToAction("IssueAnInvoice", new { InvoiceId = InvoiceId });
        }

        [Autorization(false, true)]
        public IActionResult CreateAnInvoice()
        {
            var inv = new Invoice();
            _context.Invoice.Add(inv);
            _context.SaveChanges();

            return RedirectToAction("IssueAnInvoice", new { InvoiceId = inv.Id });
        }

        [Autorization(false, true)]
        public IActionResult UpdateAnInvoice(IssueAnInvoice_VM m)
        {
            var model = m.Invoice;
            var inv = _context.Invoice.Where(w => w.Id == model.Id).FirstOrDefault();
            if (inv != null)
            {
                inv.AccountToPay = model.AccountToPay;
                inv.AdditionalBankAccount = model.AdditionalBankAccount;
                inv.Adress = model.Adress;
                inv.CountryCityPostal = model.CountryCityPostal;
                inv.Customer = model.Customer;
                inv.CustomerCountry = model.CustomerCountry;
                inv.DateOfDelivery = model.DateOfDelivery;
                inv.DateOfIssue = model.DateOfIssue;
                inv.DeadlineForPayment = model.DeadlineForPayment;
                inv.Director = model.Director;
                inv.Email = model.Email;
                inv.EstimateNumber = model.EstimateNumber;
                inv.MethodOfPayment = model.MethodOfPayment;
                inv.PDVNumber = model.PDVNumber;
                inv.PhoneFax = model.PhoneFax;
                inv.PlaceOfIssue = model.PlaceOfIssue;
                inv.SettledInBAM = model.SettledInBAM;
                inv.TotalInWords = model.TotalInWords;

                _context.Invoice.Update(inv);
                _context.SaveChanges();
            }
            return RedirectToAction("GetInvoices");
        }

        [Autorization(false, true)]
        public IActionResult RemoveInvoice(int InvoiceId)
        {
            var inv = _context.Invoice.Where(w => w.Id == InvoiceId).FirstOrDefault();
            if (inv != null)
            {
                var invtbl = _context.InvoiceTable.Where(w => w.InvoiceId == InvoiceId).ToList();
                _context.InvoiceTable.RemoveRange(invtbl);

                _context.Invoice.Remove(inv);
                _context.SaveChanges();
            }
            return RedirectToAction("GetInvoices");
        }

        [Autorization(false, true)]
        public void CreateInvoiceTable(int InvoiceId, int Rows, int Columns)
        {
            var inv = _context.Invoice.Where(w => w.Id == InvoiceId).FirstOrDefault();
            inv.TableRows = Rows;
            inv.TableColumns = Columns;
            _context.Invoice.Update(inv);
            _context.SaveChanges();
        }

        [Autorization(false, true)]
        public void SetTableData(int InvoiceId, int Row, int Column, string Value)
        {
            if (string.IsNullOrEmpty(Value)
                || InvoiceId < 0
                || (Row < 0 || Row > 25)
                || (Column < 0 || Column > 15))
                return;

            var invtable = _context.InvoiceTable.Where(w => w.InvoiceId == InvoiceId && w.Row == Row && w.Column == Column).FirstOrDefault();
            if (invtable != null)
            {
                invtable.Value = Value;
                _context.InvoiceTable.Update(invtable);
            }
            else
            {
                invtable = new InvoiceTable
                {
                    InvoiceId = InvoiceId,
                    Row = Row,
                    Column = Column,
                    Value = Value
                };
                _context.InvoiceTable.Add(invtable);
            }
            _context.SaveChanges();
        }

        [Autorization(false, true)]
        public async Task<IActionResult> RemoveInvoiceTable(int InvoiceId)
        {
            var inv = await _context.Invoice.Where(w => w.Id == InvoiceId).FirstOrDefaultAsync();
            if (inv != null)
            {
                inv.TableRows = 0;
                inv.TableColumns = 0;
                _context.Invoice.Update(inv);

                var invtables = await _context.InvoiceTable.Where(w => w.InvoiceId == InvoiceId).ToListAsync();
                _context.InvoiceTable.RemoveRange(invtables);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("IssueAnInvoice", new { InvoiceId = InvoiceId });
        }

        [Autorization(false, true)]
        public IActionResult AttachInvoiceToPurchase(int InvoiceId)
        {
            var model = new AttachInvoice_VM
            {
                InvoiceId = InvoiceId,
                PurchasesList = _context.Purchase
                                .Include(i => i.Program)
                                .Select(s => new SelectListItem
                                {
                                    Text = s.Program.Name + " (" + s.DateCreated.ToString("dd. MMM yyyy.") + ")",
                                    Value = s.Id.ToString()
                                })
                                .ToList()

            };
            return View(model);
        }

        [Autorization(false, true)]
        public IActionResult AttachInvoice(AttachInvoice_VM model)
        {
            var invoice = _context.Invoice.Where(w => w.Id == model.InvoiceId).FirstOrDefault();
            if (invoice != null)
            {
                invoice.PurchaseId = model.PurchaseId;
                _context.Invoice.Update(invoice);
                _context.SaveChanges();
            }
            return RedirectToAction("IssueAnInvoice", new { InvoiceId = model.InvoiceId });
        }

        public async Task SetParticipantGroup(int PurchaseId, int ParticipantId, int Value)
        {
            var p = await _context.PurchaseParticipants.Where(w => w.PurchaseId == PurchaseId && w.ParticipantId == ParticipantId).FirstOrDefaultAsync();
            if (p != null)
            {
                p.ParticipantGroup = Value;
                _context.PurchaseParticipants.Update(p);
                await _context.SaveChangesAsync();
            }
        }

        public async Task SetParticipantArrivalDate(int PurchaseId, int ParticipantId, DateTime Value)
        {
            var p = await _context.PurchaseParticipants.Where(w => w.PurchaseId == PurchaseId && w.ParticipantId == ParticipantId).FirstOrDefaultAsync();
            if (p != null)
            {
                p.Arrival = new DateTime(Value.Year, Value.Month, Value.Day, p.Arrival.Hour, p.Arrival.Minute, 0);
                _context.PurchaseParticipants.Update(p);
                await _context.SaveChangesAsync();
            }
        }

        public async Task SetParticipantArrivalTime(int PurchaseId, int ParticipantId, DateTime Value)
        {
            var p = await _context.PurchaseParticipants.Where(w => w.PurchaseId == PurchaseId && w.ParticipantId == ParticipantId).FirstOrDefaultAsync();
            if (p != null)
            {
                p.Arrival = new DateTime(p.Arrival.Year, p.Arrival.Month, p.Arrival.Day, Value.Hour, Value.Minute, 0);
                _context.PurchaseParticipants.Update(p);
                await _context.SaveChangesAsync();
            }
        }
    }
}
