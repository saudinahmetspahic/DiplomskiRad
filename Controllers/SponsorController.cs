using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EF;
using WebApp.EntityModels;
using WebApp.ViewModels.Sponsor;

namespace WebApp.Controllers
{
    public class SponsorController : Controller
    {
        MyContext _context;
        [Obsolete]
        private readonly IHostingEnvironment hostingEnvironment;

        [Obsolete]
        public SponsorController(MyContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult SponsorOptions()
        {
            var model = new SponsorOptions_VM();
            model.AddedSponsors = _context.Sponsor.Select(s => new SponsorOptions_VM.AddedSponsor
            {
                Id = s.Id,
                AreaOfInterest = s.AreaOfInterest,
                ImageName = s.ImageName,
                Name = s.Name
            }).ToList();
            return View(model);
        }

        [Obsolete]
        public IActionResult AddNewSponsor(SponsorOptions_VM model)
        {
            string uniqueImageName = null;
            if (model.NewSponsorToAdd.Image != null)
            {
                var uploadPath = Path.Combine(hostingEnvironment.WebRootPath, "Images", "Sponsors");
                uniqueImageName = Guid.NewGuid() + "_" + model.NewSponsorToAdd.Image.FileName;
                var filePath = Path.Combine(uploadPath, uniqueImageName);
                model.NewSponsorToAdd.Image.CopyTo(new FileStream(filePath, FileMode.Create));
            }

            var sponsor = new Sponsor
            {
                AreaOfInterest = model.NewSponsorToAdd.AreaOfInterest,
                Name = model.NewSponsorToAdd.Name,
                ImageName = uniqueImageName
            };
            _context.Sponsor.Add(sponsor);
            _context.SaveChanges();
            return RedirectToAction("SponsorOptions");
        }

        [Obsolete]
        public async Task<IActionResult> RemoveSponsor(int SponsorId)
        {
            var sponsor = await _context.Sponsor.Where(w => w.Id == SponsorId).FirstOrDefaultAsync();
            if (sponsor != null)
            {
                var oldImage = sponsor.ImageName;
                var uploadPath = Path.Combine(hostingEnvironment.WebRootPath, "Images", "Sponsors");
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
                            return RedirectToAction("SponsorOptions");
                        }

                    }
                }
                _context.Sponsor.Remove(sponsor);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("SponsorOptions");
        }

        public IActionResult GetSponsorsInfo()
        {
            var model = _context.Sponsor.Select(s => new SponsorOptions_VM.AddedSponsor
            {
                Id = s.Id,
                AreaOfInterest = s.AreaOfInterest,
                ImageName = s.ImageName,
                Name = s.Name
            }).ToList();
            return PartialView(model);
        }
    }
}
