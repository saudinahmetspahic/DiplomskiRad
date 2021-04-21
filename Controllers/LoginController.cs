using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EF;
using WebApp.EntityModels;
using WebApp.Helper;
using WebApp.ViewModels.Login;
using WebApp.ViewModels.Util;
using static WebApp.Helper.Autorization;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        MyContext _context;

        public LoginController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Login";
            return View();
        }

        public async Task<IActionResult> SignIn(Registration_VM recivedModel)
        {
            var existingAccount = _context.UserAccount.Where(w => w.Email == recivedModel.Email).Any();
            if (existingAccount)
            {
                ViewData["msg"] = "This email is already registered.";
                return View("Index");
            }

            var salt = AuthenticationServices.GenerateSalt();

            var useraccount = new UserAccount
            {
                Email = recivedModel.Email,
                Hash = AuthenticationServices.GenerateHash(salt, recivedModel.Password),
                Salt = salt
            };
            await _context.UserAccount.AddAsync(useraccount);
            await _context.SaveChangesAsync();

            var user = new User
            {
                Name = recivedModel.Name,
                Surname = recivedModel.Surname,
                Country = recivedModel.Country,
                City = recivedModel.City,
                Age = recivedModel.Age,
                Phone = recivedModel.Phone,
                UserAccountId = useraccount.Id,
                IsVIP = false,
                DateRegistered = DateTime.Now
            };
            await _context.User.AddAsync(user);
            await _context.SaveChangesAsync();


            return RedirectToAction("Index");
        }

        public IActionResult LogIn(Login_VM recivedModel)
        {
            var user = _context.UserAccount.FirstOrDefault(w => w.Email == recivedModel.Email);

            if (user == null)
            {
                ViewData["msg"] = "You are not registered. Please create your personal account.";
                return View("Index");
            }

            var salt = user.Salt;
            var modelHash = AuthenticationServices.GenerateHash(salt, recivedModel.Password);

            if (user.Hash != modelHash)
            {
                ViewData["msg"] = "Wrong email or password.";
                return View("Index");
            }
            else
            {
                HttpContext.SetLoggedUser(user);
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Account()
        {
            var user = HttpContext.GetLoggedUser();
            if (user == null)
                return RedirectToAction("Index");
            else
                return RedirectToAction("AccountDetails");
        }

        public IActionResult GetSingInFields_Ajax()
        {
            return PartialView("SignIn_Ajax");
        }


        public IActionResult AccountDetails()
        {
            var loggedUserAccount = HttpContext.GetLoggedUser();
            var loggedUser = _context.User.Include(i => i.UserAccount).Where(w => w.UserAccountId == loggedUserAccount.Id).FirstOrDefault();
            var model = new Registration_VM
            {
                Name = loggedUser.Name,
                Surname = loggedUser.Surname,
                Age = loggedUser.Age,
                City = loggedUser.City,
                Country = loggedUser.Country,
                Email = loggedUserAccount.Email,
                Phone = loggedUser.Phone,
                IsAdmin = (loggedUser.UserAccount.Role == UserRole.Admin),
                Admins = _context.User.Where(w => w.UserAccount.Role == UserRole.Admin).Select(s => new Tuple<int, string>(s.Id, s.Name + " " + s.Surname)).ToList()
            };
            return View(model);
        }

        public IActionResult GetUsers(string searchValue)
        {
            var model = _context.User.Where(w => (w.Name.Contains(searchValue) || w.Surname.Contains(searchValue)) && w.UserAccount.Role != UserRole.Admin)
                .Select(s => new ComboBox
                {
                    Id = s.Id,
                    Description = s.Name + " " + s.Surname
                })
                .ToList();
            return PartialView(model);
        }

        [Autorization(false, true)]
        public async Task<IActionResult> SetAdmin(int UserId)
        {
            var user = await _context.User.Include(i => i.UserAccount).Where(w => w.Id == UserId).FirstOrDefaultAsync();
            if (user != null)
            {
                user.UserAccount.Role = UserRole.Admin;
                _context.User.Update(user);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("AccountDetails");
        }

        [Autorization(false, true)]
        public async Task<IActionResult> UnSetAdmin(int UserId)
        {
            var user = await _context.User.Include(i => i.UserAccount).Where(w => w.Id == UserId).FirstOrDefaultAsync();
            if (user != null)
            {
                user.UserAccount.Role = UserRole.User;
                _context.User.Update(user);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("AccountDetails");
        }

        public async Task<IActionResult> UpdateAccountInfo(Registration_VM recievedModel)
        {
            var loggedUserAccount = HttpContext.GetLoggedUser();
            var loggedUser = _context.User.Where(w => w.UserAccountId == loggedUserAccount.Id).FirstOrDefault();

            loggedUserAccount.Email = recievedModel.Email;
            if (!string.IsNullOrEmpty(recievedModel.Password) && recievedModel.Password == recievedModel.ConfirmPassword)
            {
                var salt = loggedUserAccount.Salt;
                var hash = AuthenticationServices.GenerateHash(salt, recievedModel.Password);
                loggedUserAccount.Hash = hash;
            }
            _context.UserAccount.Update(loggedUserAccount);

            loggedUser.Name = recievedModel.Name;
            loggedUser.Surname = recievedModel.Surname;
            loggedUser.Age = recievedModel.Age;
            loggedUser.Country = recievedModel.Country;
            loggedUser.City = recievedModel.City;
            loggedUser.Phone = recievedModel.Phone;
            _context.User.Update(loggedUser);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public IActionResult LogOut()
        {
            HttpContext.SetLoggedUser(null);
            return RedirectToAction("Index", "Login");
        }

    }
}
