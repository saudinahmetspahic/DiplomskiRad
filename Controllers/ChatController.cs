using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EF;
using WebApp.EntityModels;
using WebApp.Helper;
using WebApp.ViewModels.Chat;
using WebApp.ViewModels.Util;
using static WebApp.Helper.Autorization;

namespace WebApp.Controllers
{
    [Autorization(true, false)]
    public class ChatController : Controller
    {
        MyContext _context;

        public ChatController(MyContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var loggedUserAccount = HttpContext.GetLoggedUser();
            var loggedUser = _context.User.Where(w => w.UserAccountId == loggedUserAccount.Id).FirstOrDefault();

            var chats = _context.Chat
                .Include(x => x.Users)
                .Where(x => (!x.Users
                    .Any(y => y.UserId == loggedUser.Id)
                   && (x.Type == ChatType.Room
                   || loggedUserAccount.Role == UserRole.Admin)))
                .ToList();
            return View(chats);
        }

        public async Task<IActionResult> JoinRoom(int id)
        {
            var loggedUserAccount = HttpContext.GetLoggedUser();
            var loggedUser = _context.User.Where(w => w.UserAccountId == loggedUserAccount.Id).FirstOrDefault();

            var chatUser = new ChatUser
            {
                ChatId = id,
                UserId = loggedUser.Id
            };

            try
            {
                _context.ChatUser.Add(chatUser);

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

            }
           

            return RedirectToAction("GetChat", new { id = id });
        }

        public async Task<IActionResult> LeaveRoom(int id)
        {
            var loggedUserAccount = HttpContext.GetLoggedUser();
            var loggedUser = _context.User.Where(w => w.UserAccountId == loggedUserAccount.Id).FirstOrDefault();

            var chatUser = _context.ChatUser.Where(w => w.ChatId == id && w.UserId == loggedUser.Id).FirstOrDefault();
            _context.ChatUser.Remove(chatUser);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> SendMessage(
            int roomId,
            string message,
            [FromServices] IHubContext<MessageHub> chat)
        {
            var loggedUserAccount = HttpContext.GetLoggedUser();
            var loggedUser = _context.User.Where(w => w.UserAccountId == loggedUserAccount.Id).FirstOrDefault();

            var msg = new Message
            {
                ChatId = roomId,
                Name = loggedUser.Name + " " + loggedUser.Surname,
                Text = message,
                Timestamp = DateTime.Now
            };
            _context.Message.Add(msg);
            _context.SaveChanges();


            await chat.Clients.Group(roomId.ToString())
                .SendAsync("RecieveMessage", new
                {
                    Text = msg.Text,
                    Name = msg.Name,
                    Timestamp = msg.Timestamp.ToString("dd/MM/yyyy hh:mm:ss")
                });

            return Ok();
        }

        public IActionResult GetChat(int id)
        {
            var chat = _context.Chat
                .Include(x => x.Messages)
                .FirstOrDefault(x => x.Id == id);

            return View(chat);
        }

        public async Task<IActionResult> CreateRoom(string name)
        {
            var loggedUser = HttpContext.GetLoggedUser();
            var user = await _context.User.Where(w => w.UserAccountId == loggedUser.Id).FirstOrDefaultAsync();

            var chat = new EntityModels.Chat
            {
                Name = name,
                Type = ChatType.Room
            };

            chat.Users.Add(new ChatUser
            {
                UserId = user.Id,
            });

            _context.Chat.Add(chat);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public IActionResult ChatSettings(int ChatId)
        {
            var c = _context.Chat.Where(w => w.Id == ChatId).FirstOrDefault();
            return View(c);
        }

        public IActionResult ChangeSettings(int chat, string name, string isprivate)
        {
            var c = _context.Chat.Where(w => w.Id == chat).FirstOrDefault();
            if (c != null)
            {
                c.Name = name;
                if (isprivate == "private")
                    c.Type = ChatType.Private;
                else if (isprivate == "public")
                    c.Type = ChatType.Room;
                _context.Chat.Update(c);
                _context.SaveChanges();
            }
            return RedirectToAction("GetChat", new { id = chat });
        }
    }
}
