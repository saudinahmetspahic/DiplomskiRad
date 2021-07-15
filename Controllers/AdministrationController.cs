using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EF;
using WebApp.EntityModels;
using WebApp.Helper;
using WebApp.ViewModels.Administration;
using WebApp.ViewModels.Util;
using static WebApp.Helper.Autorization;

namespace WebApp.Controllers
{
    [Autorization(false, true)]
    public class AdministrationController : Controller
    {
        private readonly MyContext _context;

        [Obsolete]
        private readonly IHostingEnvironment hostingEnvironment;

        [Obsolete]
        public AdministrationController(MyContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Administration Page";
            return View();
        }

        public IActionResult ActivitiesOptions()
        {

            var model = _context.Activity.Select(s => new ActivityOptions_VM
            {
                ActivityId = s.Id,
                Title = s.Title,
                NumberOfAppInPlans = _context.ProgramActivity.Where(w => w.ActivityId == s.Id).Count(),
                NumberOfAttachments = _context.ActivityAttachment.Where(w => w.ActivityId == s.Id).Count(),
                ExpectedPrice = Math.Round(_context.ActivityAttachment.Where(w => w.ActivityId == s.Id).Sum(s => s.PriceToVisit), 2),
                Rating = _context.Rate.Where(w => w.ActivityId == s.Id).Select(s => (int?)s.RateValue).Average()
            }).ToList();
            return View(model);
        }

        [Obsolete]
        public async Task<IActionResult> GetActivityDetails(int ActivityId)
        {

            var activity = await _context.Activity.Where(w => w.Id == ActivityId).FirstOrDefaultAsync();
            var uploadPath = Path.Combine("/Images", "Administration");
            var model = new GetActivityDetails_VM
            {
                ActivityId = activity.Id,
                Description = activity.Description,
                Title = activity.Title,
                ImageSrc = Path.Combine(uploadPath, string.IsNullOrEmpty(activity.ImageName) ? "default.jpg" : activity.ImageName),
                Attachments = _context.ActivityAttachment
                              .Where(w => w.ActivityId == ActivityId)
                              .Select(s => new GetActivityDetails_VM.Attachment
                              {
                                  AttachmentId = s.Id,
                                  Name = s.Name,
                                  Description = s.Description,
                                  PriceToVisit = s.PriceToVisit,
                                  TypeOfAttachment = s.TypeOfAttachment,
                                  ImageSrc = Path.Combine(uploadPath, string.IsNullOrEmpty(s.ImageName) ? "default.jpg" : s.ImageName),
                                  Addons = new List<Tuple<TypeOfAddons, int>>(_context.AttachmentAddons.Where(w => w.AttachmentId == s.Id).Select(x => new Tuple<TypeOfAddons, int>(x.AddonType, x.Distance)).ToList())
                              }).ToList()
            };
            return View(model);
        }

        public IActionResult AddAddonToAttachment(int ActivityId, int AttachmentId, int Addon)
        {
            var attachment = _context.ActivityAttachment.Where(w => w.Id == AttachmentId).FirstOrDefault();
            if (attachment != null)
            {
                var added = _context.AttachmentAddons.Where(w => w.AttachmentId == attachment.Id && w.AddonType == (TypeOfAddons)Addon).Any();
                if (!added)
                {
                    var newaddon = new AttachmentAddons
                    {
                        AddonType = (TypeOfAddons)Addon,
                        AttachmentId = attachment.Id,
                        Distance = 0
                    };
                    _context.AttachmentAddons.Add(newaddon);
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("GetActivityDetails", new { ActivityId = ActivityId });
        }


        public IActionResult SetAddonDistance(int AttachmentId, int Addon, int Distance)
        {
            var addon = _context.AttachmentAddons.Where(w => w.AttachmentId == AttachmentId && w.AddonType == (TypeOfAddons)Addon).FirstOrDefault();
            if (addon == null)
                return StatusCode(403);
            addon.Distance = Distance;
            _context.AttachmentAddons.Update(addon);
            _context.SaveChanges();
            return Ok();
        }

        public IActionResult CreateNewActivity()
        {
            return View();
        }

        [Obsolete]
        public async Task<IActionResult> AddNewActivity(AddNewActivity_VM model)
        {
            string uniqueImageName = null;
            if (model.Image != null)
            {
                var uploadPath = Path.Combine(hostingEnvironment.WebRootPath, "Images", "Administration");
                uniqueImageName = Guid.NewGuid() + "_" + model.Image.FileName;
                var filePath = Path.Combine(uploadPath, uniqueImageName);
                //model.Image.CopyTo(new FileStream(filePath, FileMode.Create));

                using (var ms = new FileStream(filePath, FileMode.Create))
                {
                    model.Image.CopyTo(ms);
                }
            }



            var activity = new Activity
            {
                Title = model.Title,
                Description = model.Description.Replace('\'', ' '),
                ImageName = uniqueImageName
            };
            await _context.Activity.AddAsync(activity);
            await _context.SaveChangesAsync();
            return RedirectToAction("GetActivityDetails", new { ActivityId = activity.Id });
        }

        public IActionResult CreateNewActivityAttachment(int ActivityId)
        {
            var model = new AddNewActivityAttachment_VM
            {
                ActivityId = ActivityId,
                TypeOfAttachmentSelect = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>()
            };

            for (int i = 0; i < 5; i++)
            {
                model.TypeOfAttachmentSelect.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Value = i.ToString(),
                    Text = ((TypeOfAttachment)i).ToString()
                });
            }
            return PartialView(model);
        }

        [Obsolete]
        public async Task<IActionResult> AddNewActivityAttachment(AddNewActivityAttachment_VM model)
        {
            string uniqueImageName = null;
            if (model.Image != null)
            {
                var uploadPath = Path.Combine(hostingEnvironment.WebRootPath, "Images", "Administration");
                uniqueImageName = Guid.NewGuid() + "_" + model.Image.FileName;
                var filePath = Path.Combine(uploadPath, uniqueImageName);
                model.Image.CopyTo(new FileStream(filePath, FileMode.Create));
            }

            var attachment = new ActivityAttachment
            {
                ActivityId = model.ActivityId,
                Name = model.Name,
                Description = model.Description.Replace('\'', ' '),
                PriceToVisit = model.PriceToVisit,
                TypeOfAttachment = model.TypeOfAttachment,
                ImageName = uniqueImageName
            };
            await _context.ActivityAttachment.AddAsync(attachment);
            await _context.SaveChangesAsync();

            return RedirectToAction("GetActivityDetails", new { ActivityId = model.ActivityId });
        }

        public async Task<IActionResult> RemoveActivity(int ActivityId)
        {
            var activity = await _context.Activity.Where(w => w.Id == ActivityId).FirstOrDefaultAsync();
            var attachments = _context.ActivityAttachment.Where(w => w.ActivityId == ActivityId).ToList();
            foreach (var attachment in attachments)
            {
                _context.ActivityAttachment.Remove(attachment);
            }
            await _context.SaveChangesAsync();
            _context.Activity.Remove(activity);
            await _context.SaveChangesAsync();
            return RedirectToAction("ActivitiesOptions");
        }

        public async Task<IActionResult> RemoveActivityAttachment(int AttachmentId)
        {
            var attachment = await _context.ActivityAttachment.Where(w => w.Id == AttachmentId).FirstOrDefaultAsync();
            _context.ActivityAttachment.Remove(attachment);
            await _context.SaveChangesAsync();
            return RedirectToAction("GetActivityDetails", new { ActivityId = attachment.ActivityId });
        }

        [Obsolete]
        public IActionResult AddNewImageToAttachment(int ActivityId, int AttachmentId)
        {
            var model = new AddNewPhoto_VM
            {
                ActivityId = ActivityId,
                AttachmentId = AttachmentId,
                ActivityOrAttachment = ActivityOrAttachment.Attachment
            };
            return PartialView("AddNewImage", model);
        }

        [Obsolete]
        public IActionResult AddNewImageToActivity(int ActivityId, int AttachmentId)
        {
            var model = new AddNewPhoto_VM
            {
                ActivityId = ActivityId,
                AttachmentId = AttachmentId,
                ActivityOrAttachment = ActivityOrAttachment.Activity
            };
            return PartialView("AddNewImage", model);
        }

        [Obsolete]
        public async Task<IActionResult> AddingNewImage(AddNewPhoto_VM model)
        {
            var uploadPath = Path.Combine(hostingEnvironment.WebRootPath, "Images", "Administration");
            string uniqueImageName = null;
            if (model.Image != null)
            {
                uniqueImageName = Guid.NewGuid() + "_" + model.Image.FileName;
            }
            else return RedirectToAction("GetActivityDetails", new { ActivityId = model.ActivityId });

            var oldImage = "";
            if (model.ActivityOrAttachment == ActivityOrAttachment.Activity)
            {
                var activity = await _context.Activity.Where(w => w.Id == model.ActivityId).FirstOrDefaultAsync();
                oldImage = activity.ImageName;
                activity.ImageName = uniqueImageName;
            }
            else
            {
                var attachment = await _context.ActivityAttachment.Where(w => w.Id == model.AttachmentId).FirstOrDefaultAsync();
                oldImage = attachment.ImageName;
                attachment.ImageName = uniqueImageName;
            }
            if (!string.IsNullOrEmpty(oldImage))
            {
                var oldImagePath = Path.Combine(uploadPath, oldImage);
                if (System.IO.File.Exists(oldImagePath))
                {
                    GC.Collect();
                    try
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                    catch (Exception)
                    {
                        return RedirectToAction("GetActivityDetails", new { ActivityId = model.ActivityId });
                    }

                }
                if (!System.IO.File.Exists(oldImagePath))
                {
                    var filePath = Path.Combine(uploadPath, uniqueImageName);

                    using (var ms = new FileStream(filePath, FileMode.Create))
                    {
                        model.Image.CopyTo(ms);
                    }
                    
                }
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("GetActivityDetails", new { ActivityId = model.ActivityId });
        }

        public void SetNewAttachmentPrice(int AttachmentId, double Price)
        {
            var attachment = _context.ActivityAttachment.Find(AttachmentId);
            if (attachment == null)
                return;
            attachment.PriceToVisit = Math.Round(Price, 2);
            _context.ActivityAttachment.Update(attachment);
            _context.SaveChanges();
        }

        public IActionResult CustomersOptions()
        {
            var model = _context.User.Select(s => new CustomersOptions_VM
            {
                Age = s.Age,
                City = s.City,
                Country = s.Country,
                Id = s.Id,
                Name = s.Name,
                Phone = s.Phone,
                Surname = s.Surname,
                Email = s.UserAccount.Email
            }).ToList();
            return View(model);
        }

        public IActionResult GetUserDetails(int UserId)
        {
            var user = _context.User.Include(i => i.UserAccount).Where(w => w.Id == UserId).FirstOrDefault();
            var model = new CustomerDetails_VM();
            model.CustomerDetails = new CustomersOptions_VM
            {
                Id = user.Id,
                Age = user.Age,
                City = user.City,
                Country = user.Country,
                Email = user.UserAccount.Email,
                Name = user.Name,
                Phone = user.Phone,
                Surname = user.Surname
            };
            model.IsVIP = user.IsVIP;
            model.DateRegistered = user.DateRegistered;
            model.NumberOfChatGroups = _context.Chat.Where(w => w.Users.Any(c => c.UserId == UserId)).Count();
            model.NumberOfPlansCreated = _context.Program.Where(w => w.CreatorId == UserId).Count();
            model.NumberOfPlansCreated_Accepted = _context.Program.Where(w => w.CreatorId == UserId && w.ProgramState == ProgramState.Approved).Count();
            model.NumberOfPlansCreated_Refused = _context.Program.Where(w => w.CreatorId == UserId && w.ProgramState == ProgramState.Refused).Count();
            model.NumberOfPlansCreated_OnHold = _context.Program.Where(w => w.CreatorId == UserId && w.ProgramState == ProgramState.OnHold).Count();
            model.NumberOfPlansOredered = _context.Purchase.Where(w => w.CreatorId == user.Id).Count();

            model.PlansCreated_Redirection = _context.Program.Where(w => w.CreatorId == UserId).Select(s => new CustomerDetails_VM.CreatedPlan_Details
            {
                DateCreated = s.Date_Created,
                Id = s.Id,
                Description = s.Description,
                Title = s.Name,
                NumberOfSells = _context.Purchase.Where(w => w.ProgramId == s.Id).Count()
            }).ToList();
            if (model.PlansCreated_Redirection == null)
                model.PlansCreated_Redirection = new List<CustomerDetails_VM.CreatedPlan_Details>();


            model.PlansOrdered_Redirection = new List<CustomerDetails_VM.OrderedPlan_Details>();
            var purchases = _context.Purchase.Include(i => i.Program).Where(w => w.CreatorId == user.Id).ToList();
            foreach (var purchase in purchases)
            {
                var activities = _context.ProgramActivity.Where(w => w.ProgramId == purchase.ProgramId);
                var date_start = activities.OrderBy(o => o.Start).Select(s => s.Start).FirstOrDefault();
                var date_finish = activities.OrderByDescending(o => o.Start).Select(s => s.Start.AddHours(s.DedicatedHours)).FirstOrDefault();

                model.PlansOrdered_Redirection.Add(new CustomerDetails_VM.OrderedPlan_Details
                {
                    Id = purchase.Id,
                    DateOrdered = purchase.DateCreated,
                    DateFinish = date_finish,
                    DateStart = date_start,
                    Description = purchase.Program.Description,
                    Title = purchase.Program.Name,
                    Finished = date_finish.CompareTo(DateTime.Now) < 0,
                    ForGroup = _context.PurchaseParticipants.Where(w => w.PurchaseId == purchase.Id).Count() > 1
                });
            }
            return View(model);
        }

        public IActionResult ProgramsOptions()
        {
            var model = _context.Program.Select(s => new ProgramsOptions_VM
            {
                Id = s.Id,
                Date_Created = s.Date_Created,
                Name = s.Name,
                ProgramAccess = s.ProgramAccess,
                ProgramState = s.ProgramState,
                Creator = s.Creator.Name + " " + s.Creator.Surname
            }).ToList();
            return View(model);
        }

        public IActionResult GetProgramDetails(int ProgramId)
        {
            var program = _context.Program.Include(i => i.Creator).Where(w => w.Id == ProgramId).FirstOrDefault();
            var price = 0.0;
            var activities = _context.ProgramActivity.Include(i => i.Activity).Where(w => w.ProgramId == program.Id).ToList();
            foreach (var activity in activities)
            {
                price = _context.ProgramActivityAttachment.Where(w => w.ProgramActivityId == activity.Id).Sum(s => s.ActivityAttachment.PriceToVisit);
            }
            var model = new GetProgramDetails_VM
            {
                ProgramDetails = new ProgramsOptions_VM
                {
                    Id = program.Id,
                    Creator = program.Creator.Name + " " + program.Creator.Surname,
                    Name = program.Name,
                    Date_Created = program.Date_Created,
                    ProgramAccess = program.ProgramAccess,
                    ProgramState = program.ProgramState
                },
                DateStateChanged = program.DateStateChanged,
                DateAccessChanged = program.DateAccessChanged,
                NumberOfSells = _context.Purchase.Count(w => w.ProgramId == program.Id),
                ProgramPriceExpected = price,
                TotalPriceOfSellsExpected = price * _context.PurchaseParticipants.Count(w => w.Purchase.ProgramId == program.Id), // ( price * broj ljudi na planu )
                Activities = activities.Select(s => new GetProgramDetails_VM._Activity
                {
                    Title = s.Activity.Title,
                    DayOfProgram = s.DayOfProgram,
                    Description = s.Activity.Description,
                    ImageName = s.Activity.ImageName,
                    Attachments = _context.ProgramActivityAttachment.Where(w => w.ProgramActivityId == s.Id).Select(x => new GetProgramDetails_VM._Attachment
                    {
                        Description = x.ActivityAttachment.Description,
                        ImageName = x.ActivityAttachment.ImageName,
                        Price = x.ActivityAttachment.PriceToVisit,
                        Title = x.ActivityAttachment.Name
                    }).ToList()
                }).ToList()
            };
            return View(model);
        }

        public IActionResult ChangeProgramState(int ProgramId, int State)
        {
            var program = _context.Program.Where(w => w.Id == ProgramId).FirstOrDefault();
            if (program == null)
                return StatusCode(400);

            program.ProgramState = (ProgramState)State;
            program.DateStateChanged = DateTime.Now;
            _context.Program.Update(program);
            _context.SaveChanges();
            return Ok();
        }

        public IActionResult ChangeProgramAccess(int ProgramId, int Access)
        {
            var program = _context.Program.Where(w => w.Id == ProgramId).FirstOrDefault();
            if (program == null)
                return StatusCode(400);

            if ((ProgramAccess)Access == ProgramAccess.Public)
            {
                if (string.IsNullOrEmpty(program.Description))
                {
                    return StatusCode(412); // precondition
                }
            }

            program.ProgramAccess = (ProgramAccess)Access;
            program.DateAccessChanged = DateTime.Now;
            _context.Program.Update(program);
            _context.SaveChanges();
            return Ok();
        }

        public IActionResult NotificationsOptions()
        {
            return View();
        }

        public IActionResult PurchasesOptions()
        {
            var model = _context.Purchase.Select(s => new PurchasesOptions_VM
            {
                Id = s.Id,
                Creator = s.Creator.Name + " " + s.Creator.Surname,
                DateCreated = s.DateCreated,
                ProgramName = s.Program.Name,
                ParticipantsCount = _context.PurchaseParticipants.Where(w => w.PurchaseId == s.Id).Count()
            }).OrderByDescending(o => o.DateCreated).ToList();
            return View(model);
        }

        public async Task<IActionResult> AddProgramDescription(int ProgramId, string Description)
        {
            var program = await _context.Program.Where(w => w.Id == ProgramId).FirstOrDefaultAsync();
            if (program == null)
                return StatusCode(400);
            program.Description = Description.Replace('\'', ' ');
            _context.Program.Update(program);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}

