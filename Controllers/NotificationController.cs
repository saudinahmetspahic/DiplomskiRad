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
using WebApp.Helper;
using WebApp.ViewModels.Notification;

namespace WebApp.Controllers
{
    public class NotificationController : Controller
    {
        MyContext _context;
        [Obsolete]
        private readonly IHostingEnvironment hostingEnvironment;

        [Obsolete]
        public NotificationController(MyContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult GetNotifications(bool AllowModifications)
        {
            var notifications = _context.Notification.Select(s => new GetNotifications_VM
            {
                Id = s.Id,
                Title = s.Title,
                DateCreated = s.DateCreated,
                Description = s.Description,
                ImageName = s.ImageName,
                Author = s.Author.Name + " " + s.Author.Surname,
                AllowModifications = AllowModifications
            }).ToList();
            return PartialView(notifications);
        }

        [Obsolete]
        public async Task<IActionResult> CreateNewNotification(CreateNotification_VM model)
        {
            var loggedUser = HttpContext.GetLoggedUser();
            var user = _context.User.Where(w => w.UserAccountId == loggedUser.Id).FirstOrDefault();

            string uniqueImageName = null;
            if (model.Image != null)
            {
                var uploadPath = Path.Combine(hostingEnvironment.WebRootPath, "Images", "Notification");
                uniqueImageName = Guid.NewGuid() + "_" + model.Image.FileName;
                var filePath = Path.Combine(uploadPath, uniqueImageName);
                model.Image.CopyTo(new FileStream(filePath, FileMode.Create));
            }

            var notification = new Notification
            {
                Title = model.Title,
                Description = model.Description,
                DateCreated = DateTime.Now,
                AuthorId = user.Id,
                ImageName = uniqueImageName
            };
            await _context.Notification.AddAsync(notification);
            await _context.SaveChangesAsync();
            return RedirectToAction("NotificationsOptions", "Administration");
        }

        public async Task<IActionResult> RemoveNotification(int NotificationId)
        {
            var notification = await _context.Notification.Where(w => w.Id == NotificationId).FirstOrDefaultAsync();
            if (notification != null)
            {
                _context.Notification.Remove(notification);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return StatusCode(400);
        }

        public IActionResult GetNotificationDetails(int NotificationId)
        {
            var notif = _context
                            .Notification
                            .Where(w => w.Id == NotificationId)
                            .Select(s => new GetNotifications_VM
                            {
                                Author = s.Author.Name + " " + s.Author.Surname,
                                Description = s.Description,
                                DateCreated = s.DateCreated,
                                Title = s.Title,
                                ImageName = s.ImageName
                            })
                            .FirstOrDefault();
            return PartialView(notif);
        }
    }
}
