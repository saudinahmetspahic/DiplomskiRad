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

namespace WebApp.Controllers
{
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
                    var programs = _context.ProgramActivity.Where(w => w.ActivityId == activity).Select(s => s.Program).ToList();

                    foreach (var program in programs)
                    {
                        result.Add(program.Id);
                        model.Add(new GetPrograms_VM
                        {
                            Id = program.Id,
                            Name = program.Name,
                            Description = program.Description
                        });
                    }
                }
            }

            return PartialView(model);
        }

        public JsonResult GetTagInfo(int TagId)
        {
            var result = _context.ActivityAttachment.Where(w => w.Id == TagId).FirstOrDefault();
            return Json(result);
        }

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
                ProgramStatus = ProgramStatus.OnHold,
                Date_Created = DateTime.Now
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

        public IActionResult AddActivityToProgram(string ProgramName, int ActivityId, int Day)
        {
            var program = _context.Program.Where(w => w.Name == ProgramName).FirstOrDefault();
            if (program == null)
                return StatusCode(400);
            var activity = new ProgramActivity
            {
                ActivityId = ActivityId,
                ProgramId = program.Id,
                DayOfProgram = Day
            };
            _context.ProgramActivity.Add(activity);
            _context.SaveChanges();
            return Ok();
        }


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
            //var description = _context.Activity.Where(w => w.Id == ActivityId).Select(s => new ComboBox
            //{
            //    Id = ActivityId,
            //    Description = s.Description
            //}).FirstOrDefault();
            //return Json(description);
            var model = _context.Activity.Where(w => w.Id == ActivityId).Select(s => new GetActivityDetails_VM
            {
                Id = s.Id,
                Description = s.Description,
                ImageName = s.ImageName,
                Title = s.Title
            }).FirstOrDefault();
            return PartialView(model);
        }

        public IActionResult GetAttachmentDescription(int AttachmentId)
        {
            var model = _context.ActivityAttachment.Where(w => w.Id == AttachmentId).Select(s => new GetActivityAttachments_VM
            {
                Id = AttachmentId,
                Description = s.Description,
                ImageName = s.ImageName,
                Name = s.Name,
                PriceToVisit = s.PriceToVisit,
                TypeOfAttachment = s.TypeOfAttachment
            }).FirstOrDefault();
            return PartialView(model);
        }

        public IActionResult GetActivitiesAjax(string Value)
        {
            var model = _context.Activity
                .Where(w => w.Description.Contains(Value) || string.IsNullOrEmpty(Value))
                .Select(s => new ComboBox
                {
                    Id = s.Id,
                    Description = s.Description
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

        public async Task<IActionResult> GetActivityAttachments(int ActivityId)
        {
            var attachments = await _context.ActivityAttachment.Where(w => w.ActivityId == ActivityId).Select(s => new GetActivityAttachments_VM
            {
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

            var activities = _context.ProgramActivity.Where(w => w.ProgramId == ProgramId).ToList();
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

        public IActionResult AddAttachmentToProgramActivity(string ProgramName, int ActivityId, int Day, int AttachmentId)
        {
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
            _context.ProgramActivityAttachment.Add(attachment);
            _context.SaveChanges();
            return StatusCode(200);
        }

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
    }
}
