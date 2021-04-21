using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EF;
using WebApp.EntityModels;
using WebApp.Helper;
using WebApp.ViewModels.Purchase;

namespace WebApp.Controllers
{
    public class PurchaseController : Controller
    {
        MyContext _context;

        public PurchaseController(MyContext context)
        {
            _context = context;
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
                    ParticipantId = x.ParticipantId
                }).ToList()
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
                    PurchaseId = purchase.Id
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
                    ParticipantId = UserId
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

        public IActionResult IssueAnInvoice(int PurchaseId)
        {
            if (PurchaseId > 0)
            {

            }
            return View();
        }
    }
}
