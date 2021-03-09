using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EF;
using WebApp.EntityModels;
using WebApp.ViewModels.Administration;

namespace WebApp.Controllers
{
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
            return View();
        }

        [Obsolete]
        public IActionResult AddNewActivity(AddNewActivity_VM model)
        {
            string uniqueImageName = null;
            if(model.Image != null)
            {
                var uploadPath = Path.Combine(hostingEnvironment.WebRootPath, "Images", "Administration");
                uniqueImageName = Guid.NewGuid() + "_" + model.Image.FileName;
                var filePath = Path.Combine(uploadPath, uniqueImageName);
                model.Image.CopyTo(new FileStream(filePath, FileMode.Create));
            }

            _context.Activity.Add(new Activity
            {
                Description = model.Description,
                ImageName = uniqueImageName
            });
            return RedirectToAction("Index");
        }
    }
}
