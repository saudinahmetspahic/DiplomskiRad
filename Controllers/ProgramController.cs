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

            var activityActivityAttachments = _context.ActivityActivityAttachment.AsQueryable();
            var result = new List<int>();
            var tags = TagList.Split(",");
            foreach (var i in tags)
            {
                if (i.Contains("Tag"))
                {
                    var id = int.Parse(i.Substring(4));
                    // w.ActivityAttachmentId moze praviti problem
                    var activities = activityActivityAttachments.Where(w => w.ActivityAttachmentId == id).Select(s => s.ActivityId).ToList();
                    foreach (var activity in activities)
                    {
                        var programDayActivities = _context.ProgramDayActivity.Where(w => w.ActivityAttachmentId == activity).ToList();
                        foreach (var programDayActivity in programDayActivities)
                        {
                            var programs = _context.ProgramProgramDay.Include(i => i.Program).Where(w => w.ProgramDayId == programDayActivity.ProgramDayId && result.Contains(w.ProgramId) == false && w.Program.IsApproved == true).Select(s => s.Program).ToList(); // include
                            foreach (var p in programs)
                            {
                                result.Add(p.Id);
                                model.Add(new GetPrograms_VM
                                {
                                    Id = p.Id,
                                    Name = p.Name,
                                    Description = p.Description
                                });
                            }

                        }
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


        public IActionResult CreateCustomnPlan()
        {
            return PartialView(new CreateCustomProgram_VM());
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

   
    }
}
