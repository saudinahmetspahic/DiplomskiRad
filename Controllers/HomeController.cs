using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EF;
using WebApp.Models;
using WebApp.Helper;
using static WebApp.Helper.Autorization;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var notif = _context.Notification.OrderByDescending(o => o.DateCreated).Take(8).ToList();

            ViewData["Title"] = "Home Page";
            return View(notif);
        }

        [Autorization(true, false)]
        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact Page";
            return View();
        }



    }
}
