using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using WebApp.EF;
using WebApp.ViewModels.Program;
using WebApp.ViewModels.Util;
using System.Web;
using WebApp.EntityModels;
using WebApp.Helper;
using static WebApp.Helper.Autorization;

namespace WebApp.Controllers
{
    [Autorization(true, true, true)]
    public class ProgramController : Controller
    {
        MyContext _context;

        public ProgramController(MyContext context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {
            ViewData["Title"] = "Program Page";
            return View();
        }

        public IActionResult GetSearchPlansOptions()
        {

            return PartialView();
        }

        public IActionResult GetTags(string Keyword)
        {
            var tags = _context.ActivityAttachment
                .Where(w => w.Name.Contains(Keyword) || w.Description.Contains(Keyword))
                .Select(s => new ComboBox
                {
                    Id = s.Id,
                    Description = s.Name
                })
                .ToList();
            return PartialView(tags);
        }

        public IActionResult GetPrograms(string TagList)
        {
            var model = new List<GetPrograms_VM>();

            var result = new List<int>();
            var tags = TagList.Split(",");
            foreach (var i in tags)
            {
                if (i.Contains("Tag"))
                {
                    var id = int.Parse(i.Substring(4));
                    var activity = _context.ActivityAttachment.Where(w => w.Id == id).Select(s => s.ActivityId).FirstOrDefault();
                    var programs = _context.ProgramActivity.Where(w => w.ActivityId == activity && w.Program.ProgramAccess == ProgramAccess.Public && w.Program.ProgramState == ProgramState.Approved).Select(s => s.Program).ToList();

                    foreach (var program in programs)
                    {
                        if (!result.Contains(program.Id))
                        {
                            result.Add(program.Id);
                            model.Add(new GetPrograms_VM
                            {
                                Id = program.Id,
                                Name = program.Name,
                                Description = program.Description,
                                Activities = _context.ProgramActivity.Where(w => w.ProgramId == program.Id).Select(s => s.Activity.Title).Take(5).ToList()
                            });
                        }
                    }
                }
            }

            return PartialView(model);
        }

        public async Task<IActionResult> GetProgramPreviews(int[] filterIds, int numberOfPrograms)
        {
            var programs = await _context.Program.Where(w => w.ProgramAccess == ProgramAccess.Public && w.ProgramState == ProgramState.Approved && !filterIds.Contains(w.Id)).OrderBy(o => o.DateAccessChanged).Take(numberOfPrograms).ToListAsync();
            var model = programs.Select(s => new GetPrograms_VM
            {
                Id = s.Id,
                Name = s.Name,
                Description = s.Description,
                Activities = _context.ProgramActivity.Where(w => w.ProgramId == s.Id).OrderBy(o => o.DayOfProgram).Select(x => x.Activity.Title).Take(3).ToList()
            }).ToList();
            if (model.Count() != numberOfPrograms && numberOfPrograms < 3)
                return StatusCode(406); // not acceptable
            return PartialView(model);
        }

        public JsonResult GetTagInfo(int TagId)
        {
            var result = _context.ActivityAttachment.Where(w => w.Id == TagId).FirstOrDefault();
            return Json(result);
        }

        [Autorization(true, true, false)]
        public IActionResult CreateProgram(string ProgramName)
        {
            if (_context.Program.Where(w => w.Name == ProgramName).Any())
                return StatusCode(400);

            var loggedUserAccount = HttpContext.GetLoggedUser();
            var loggedUser = _context.User.Where(w => w.UserAccountId == loggedUserAccount.Id).FirstOrDefault();
            var program = new EntityModels.Program
            {
                Name = ProgramName,
                CreatorId = loggedUser.Id,
                ProgramAccess = ProgramAccess.Private,
                ProgramState = ProgramState.OnHold,
                Date_Created = DateTime.Now,
                DateAccessChanged = DateTime.Now,
                DateStateChanged = DateTime.Now
            };
            _context.Program.Add(program);
            _context.SaveChanges();

            var arrival = _context.Activity.Where(w => w.Title == "Arrival").FirstOrDefault();
            if (arrival != null)
            {
                var day = new ProgramActivity
                {
                    DayOfProgram = 1,
                    ProgramId = program.Id,
                    ActivityId = arrival.Id
                };
                _context.ProgramActivity.Add(day);
                _context.SaveChanges();
            }
            return Ok();
        }

        [Autorization(true, true, false)]
        public IActionResult AddActivityToProgram(string ProgramName, int ActivityId, int Day)
        {
            if (ProgramApproved(ProgramName))
                return StatusCode(401);
            var program = _context.Program.Where(w => w.Name == ProgramName).FirstOrDefault();
            if (program == null)
                return StatusCode(400);
            var activity = new ProgramActivity
            {
                ActivityId = ActivityId,
                ProgramId = program.Id,
                DayOfProgram = Day
            };
            if (_context.ProgramActivity.Where(w => w.ActivityId == ActivityId && w.ProgramId == program.Id && w.DayOfProgram == Day).Any())
                return StatusCode(409); // duplicate
            _context.ProgramActivity.Add(activity);

            // nepotrebno
            //var loggedUserAccount = HttpContext.GetLoggedUser();
            //var loggedUser = _context.User.Where(w => w.UserAccountId == loggedUserAccount.Id).FirstOrDefault();
            //if(program.CreatorId != loggedUser.Id) {
            program.DateStateChanged = DateTime.Now;
            program.DateAccessChanged = DateTime.Now;
            program.ProgramState = ProgramState.OnHold;
            program.ProgramAccess = ProgramAccess.Private;
            _context.Program.Update(program);
            // zavrsiti - dodati obavijest da je doslo do promijene
            // }

            _context.SaveChanges();
            return Ok();
        }

        [Autorization(true, true, false)]
        public async Task<IActionResult> RemoveActivityFromProgram(string ProgramName, int ActivityId, int Day)
        {
            if (ProgramApproved(ProgramName))
                return StatusCode(401);
            var program = await _context.Program.Where(w => w.Name == ProgramName).FirstOrDefaultAsync();
            if (program == null)
                return StatusCode(400);
            var activity = await _context.ProgramActivity.Where(w => w.ProgramId == program.Id && w.ActivityId == ActivityId && w.DayOfProgram == Day).FirstOrDefaultAsync();
            var attachments = await _context.ProgramActivityAttachment.Where(w => w.ProgramActivityId == activity.Id).ToListAsync();
            foreach (var attachment in attachments)
            {
                _context.ProgramActivityAttachment.Remove(attachment);
            }
            _context.ProgramActivity.Remove(activity);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [Autorization(true, true, false)]
        public IActionResult CreateCustomPlan()
        {
            var loggedUserAccount = HttpContext.GetLoggedUser();
            var loggedUser = _context.User.Where(w => w.UserAccountId == loggedUserAccount.Id).FirstOrDefault();
            var model = new CreateCustomProgram_VM
            {
                OldPrograms = _context.Program.Where(w => w.CreatorId == loggedUser.Id).Select(s => new CreateCustomProgram_VM.OldProgram
                {
                    Id = s.Id,
                    DateCreated = s.Date_Created,
                    Title = s.Name
                }).ToList()
            };
            return PartialView(model);
        }

        public IActionResult GetActivityDescription(int ActivityId)
        {
            var model = _context.Activity.Where(w => w.Id == ActivityId).Select(s => new GetActivityDetails_VM
            {
                Id = s.Id,
                Description = s.Description,
                ImageName = s.ImageName,
                Title = s.Title
            }).FirstOrDefault();
            return PartialView(model);
        }

        public IActionResult GetAttachmentDescription(int AttachmentId, bool AllowModifications)
        {
            var model = _context.ActivityAttachment.Where(w => w.Id == AttachmentId).Select(s => new GetActivityAttachments_VM
            {
                Id = AttachmentId,
                Description = s.Description,
                ImageName = s.ImageName,
                Name = s.Name,
                PriceToVisit = s.PriceToVisit,
                TypeOfAttachment = s.TypeOfAttachment,
                AllowModifications = AllowModifications
            }).FirstOrDefault();
            return PartialView(model);
        }

        public IActionResult GetActivitiesAjax(string Value)
        {
            var model = _context.Activity
                .Where(w => w.Title.Contains(Value) || w.Description.Contains(Value) || string.IsNullOrEmpty(Value))
                .Select(s => new ComboBox
                {
                    Id = s.Id,
                    Description = s.Title
                }).ToList();
            return PartialView(model);
        }

        public async Task<IActionResult> GetActivityDetailsAjax(int ActivityId)
        {
            var activity = await _context.Activity.Where(w => w.Id == ActivityId).FirstOrDefaultAsync();
            var model = new GetActivityDetails_VM
            {
                Id = activity.Id,
                Description = activity.Description
            };
            return PartialView(model);
        }

        public async Task<IActionResult> GetActivityAttachments(int ActivityId, int Day)
        {
            var attachments = await _context.ActivityAttachment.Where(w => w.ActivityId == ActivityId).Select(s => new GetActivityAttachments_VM
            {
                Day = Day,
                ActivityId = ActivityId,
                Id = s.Id,
                Description = s.Description,
                ImageName = s.ImageName,
                Name = s.Name,
                PriceToVisit = s.PriceToVisit,
                TypeOfAttachment = s.TypeOfAttachment
            }).ToListAsync();
            return PartialView(attachments);
        }

        public IActionResult LoadProgramData(int ProgramId)
        {
            var model = new List<GetProgramData_VM>();

            var activities = _context.ProgramActivity.Where(w => w.ProgramId == ProgramId).OrderBy(o => o.DayOfProgram).ToList();
            foreach (var activity in activities)
            {
                var attachments = _context.ProgramActivityAttachment.Where(w => w.ProgramActivityId == activity.Id).ToList();
                if (attachments.Any())
                {
                    foreach (var attachment in attachments)
                    {
                        model.Add(new GetProgramData_VM { Day = activity.DayOfProgram, Activity = activity.ActivityId, Attachment = attachment.ActivityAttachmentId });
                    }
                }
                else
                    model.Add(new GetProgramData_VM { Day = activity.DayOfProgram, Activity = activity.ActivityId, Attachment = 0 });
            }

            return Json(model);
        }

        [Autorization(true, true, false)]
        public IActionResult AddAttachmentToProgramActivity(string ProgramName, int ActivityId, int Day, int AttachmentId)
        {
            if (ProgramApproved(ProgramName))
                return StatusCode(401);
            var program = _context.Program.Where(w => w.Name == ProgramName).FirstOrDefault();
            if (program == null)
                return StatusCode(400);

            var programactivity = _context.ProgramActivity.Where(w => w.ProgramId == program.Id && w.ActivityId == ActivityId && w.DayOfProgram == Day).FirstOrDefault();
            if (programactivity == null)
                return StatusCode(400);

            var attachment = new ProgramActivityAttachment
            {
                ActivityAttachmentId = AttachmentId,
                ProgramActivityId = programactivity.Id,
                //zavrsiti
            };
            if (_context.ProgramActivityAttachment.Where(w => w.ProgramActivityId == programactivity.Id && w.ActivityAttachmentId == AttachmentId).Any())
                return StatusCode(409); // duplicate
            _context.ProgramActivityAttachment.Add(attachment);

            // nepotrebno
            //var loggedUserAccount = HttpContext.GetLoggedUser();
            //var loggedUser = _context.User.Where(w => w.UserAccountId == loggedUserAccount.Id).FirstOrDefault();
            //if (program.CreatorId != loggedUser.Id)
            //{
            program.ProgramAccess = ProgramAccess.Private;
            program.ProgramState = ProgramState.OnHold;
            program.DateStateChanged = DateTime.Now;
            program.DateAccessChanged = DateTime.Now;
            _context.Program.Update(program);
            // zavrsiti - poslati obavijest korisniku da je doslo do promijena
            //}
            _context.SaveChanges();
            return StatusCode(201);
        }

        [Autorization(true, true, false)]
        public async Task<IActionResult> RemoveAttachmentFromProgramActivity(string ProgramName, int ActivityId, int Day, int AttachmentId)
        {
            if (ProgramApproved(ProgramName))
                return StatusCode(401);
            var program = await _context.Program.Where(w => w.Name == ProgramName).FirstOrDefaultAsync();
            if (program == null)
                return StatusCode(400);

            var programactivity = await _context.ProgramActivity.Where(w => w.ProgramId == program.Id && w.ActivityId == ActivityId && w.DayOfProgram == Day).FirstOrDefaultAsync();
            if (programactivity == null)
                return StatusCode(400);

            var attachment = await _context.ProgramActivityAttachment.Where(w => w.ProgramActivityId == programactivity.Id && w.ActivityAttachmentId == AttachmentId).FirstOrDefaultAsync();
            if (attachment == null)
                return StatusCode(400);

            _context.ProgramActivityAttachment.Remove(attachment);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [Autorization(true, true, false)]
        public IActionResult RemoveProgram(int ProgramId)
        {
            var activities = _context.ProgramActivity.Where(w => w.ProgramId == ProgramId).ToList();
            foreach (var activity in activities)
            {
                var attachments = _context.ProgramActivityAttachment.Where(w => w.ProgramActivityId == activity.Id).ToList();
                foreach (var attachment in attachments)
                {
                    _context.ProgramActivityAttachment.Remove(attachment);
                }
            }
            foreach (var activity in activities)
            {
                _context.ProgramActivity.Remove(activity);
            }
            var program = _context.Program.Where(w => w.Id == ProgramId).FirstOrDefault();
            _context.Program.Remove(program);
            _context.SaveChanges();

            return RedirectToAction("ProgramsOptions", "Administration");
        }

        [Autorization(true, true, false)]
        public async Task<int> ChangeDay(string ProgramName, int OldValue, int NewValue)
        {
            var program = await _context.Program.Where(w => w.Name == ProgramName).FirstOrDefaultAsync();
            if (ProgramApproved(ProgramName))
                return program.Id;
            var activities = await _context.ProgramActivity.Where(w => w.ProgramId == program.Id && w.DayOfProgram == OldValue).ToListAsync();
            foreach (var activity in activities)
            {
                activity.DayOfProgram = NewValue;
                _context.ProgramActivity.Update(activity);
            }
            await _context.SaveChangesAsync();
            return program.Id;
        }

        public IActionResult ShowProgramDetails(int ProgramId)
        {
            var model = _context.Program.Where(w => w.Id == ProgramId).Select(s => new ShowProgramDetails_VM
            {
                Id = s.Id,
                Description = s.Description,
                Title = s.Name
            }).FirstOrDefault();
            return View(model);
        }

        [Autorization(true, true, false)]
        public async Task ChangeActivityTime(string ProgramName, int Activity, int Day, DateTime Time)
        {
            if (ProgramApproved(ProgramName))
                return;
            var activity = await _context.ProgramActivity.Where(w => w.Program.Name == ProgramName && w.ActivityId == Activity && w.DayOfProgram == Day).FirstOrDefaultAsync();
            activity.Start = Time;
            _context.ProgramActivity.Update(activity);
            await _context.SaveChangesAsync();
        }

        public string GetCurrentTimeOfActivity(string ProgramName, int Activity, int Day)
        {
            var date = _context.ProgramActivity.Where(w => w.Program.Name == ProgramName && w.ActivityId == Activity && w.DayOfProgram == Day).Select(s => s.Start).FirstOrDefault();
            return date.ToString("HH:mm");
        }

        [Autorization(true, true, false)]
        public async Task ChangeActivityDuration(string ProgramName, int Activity, int Day, int DedicatedHours)
        {
            if (ProgramApproved(ProgramName))
                return;
            var activity = await _context.ProgramActivity.Where(w => w.Program.Name == ProgramName && w.ActivityId == Activity && w.DayOfProgram == Day).FirstOrDefaultAsync();
            activity.DedicatedHours = DedicatedHours;
            _context.ProgramActivity.Update(activity);
            await _context.SaveChangesAsync();
        }

        public int GetActivityDuration(string ProgramName, int Activity, int Day)
        {
            var hours = _context.ProgramActivity.Where(w => w.Program.Name == ProgramName && w.ActivityId == Activity && w.DayOfProgram == Day).Select(s => s.DedicatedHours).FirstOrDefault();
            return hours;
        }

        [Autorization(true, true, false)]
        public IActionResult RateProgram(int ProgramId)
        {
            var loggedUserAccount = HttpContext.GetLoggedUser();
            var loggedUser = _context.User.Where(w => w.UserAccountId == loggedUserAccount.Id).FirstOrDefault();
            var au = _context.PurchaseParticipants.Where(w => w.ParticipantId == loggedUser.Id && w.Purchase.ProgramId == ProgramId).Any();
            if (au)
            {
                var program = _context.Program.Where(w => w.Id == ProgramId).FirstOrDefault();
                var model = new RateProgram_VM
                {
                    ProgramId = ProgramId,
                    ProgramName = program.Name,

                };
                var activities = _context.ProgramActivity.Include(i => i.Activity).Where(w => w.ProgramId == program.Id).Select(s => s.Activity).Distinct().ToList();
                model.Activities = activities.Select(s => new RateProgram_VM.RateActivity
                {
                    ActivityId = s.Id,
                    Description = s.Description,
                    Image = s.ImageName,
                    CurrentRate = _context.Rate.Where(w => w.ActivityId == s.Id).Select(x => (int?)x.RateValue).Average() ?? 1.0,
                    GivenRate = 1
                }).ToList();
                return View(model);
            }
            return StatusCode(403);
        }

        [Autorization(true, true, false)]
        public void RatingProgram(int ProgramId, int ActivityId, int Rate)
        {
            var loggedUserAccount = HttpContext.GetLoggedUser();
            var loggedUser = _context.User.Where(w => w.UserAccountId == loggedUserAccount.Id).FirstOrDefault();

            if(_context.Activity.Where(w => w.Id == ActivityId).Any())
            {
                var rate = _context.Rate.Where(w => w.ActivityId == ActivityId && w.UserId == loggedUser.Id).FirstOrDefault();
                if (rate == null)
                {
                    rate = new Rate
                    {
                        ActivityId = ActivityId,
                        UserId = loggedUser.Id,
                        RateValue = Rate
                    };
                    _context.Rate.Add(rate);
                }
                else
                {
                    rate.RateValue = Rate;
                    _context.Rate.Update(rate);
                }
               
                _context.SaveChanges();
            }
        }

        private bool ProgramApproved(string ProgramName)
        {
            var program = _context.Program.Where(w => w.Name == ProgramName).FirstOrDefault();
            if(program != null)
            {
                if (program.ProgramState == ProgramState.Approved)
                    return true;
            }
            return false;
        }
    }
}
