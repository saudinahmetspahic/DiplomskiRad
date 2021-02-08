using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EF;
using WebApp.ViewModels.Program;
using WebApp.ViewModels.Util;

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
                    var activities = activityActivityAttachments.Where(w => w.ActivityAttachmentId == id).Select(s => s.ActivityId).ToList();
                    foreach (var activity in activities)
                    {
                        var programDayActivities = _context.ProgramDayActivity.Where(w => w.ActivityId == activity).ToList();
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

    }
}
