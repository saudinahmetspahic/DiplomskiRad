using ClassModels;
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
            ViewData["Title"] = "Home Page";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact Page";
            return View();
        }



    }
}
