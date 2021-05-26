﻿using Microsoft.AspNetCore.Mvc;
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







        //public async Task<IActionResult> OpenGroupChatBox(int GroupChatId)
        //{
        //    var loggedUser = HttpContext.GetLoggedUser();
        //    var user = await _context.User.Where(w => w.UserAccountId == loggedUser.Id).FirstOrDefaultAsync();
        //    var groupChat = await _context.GroupChat.Where(w => w.Id == GroupChatId).FirstOrDefaultAsync();

        //    var model = new GroupChatListingMessages_VM
        //    {
        //        GroupChatId = groupChat.Id,
        //        UserId = user.Id,
        //        GroupName = groupChat.Name
        //        //Messages = new List<GroupChatListingMessages_VM.Message>(),
        //        //Participants = new List<string>()
        //    };

        //    model.Participants = await _context.GroupChatParticipants
        //        .Where(w => w.GroupChatId == GroupChatId)
        //        .Select(s => s.User.Name + " " + s.User.Surname)
        //        .Distinct()
        //        .ToListAsync();

        //    model.Messages = await _context.GroupChatMessage
        //        .Where(w => w.GroupChatId == GroupChatId)
        //        .Select(s => new GroupChatListingMessages_VM.Message
        //        {
        //            MessageContent = s.Message.MessageContent,
        //            SenderId = s.Message.SenderId,
        //            SenderName = s.Message.Sender.Name,
        //            SendingDate = s.Message.SendingTime
        //        })
        //        //.OrderBy(o => o.SendingDate)
        //        .Distinct()
        //        .ToListAsync();
        //    return PartialView("OpenGroupChatBox_Ajax", model);
        //}

        //public async Task<IActionResult> OpenChatBox(int UserId)
        //{
        //    var loggedUser = HttpContext.GetLoggedUser();
        //    var participants = _context.User.Include(i => i.UserAccount).Where(w => (w.Id == UserId && w.UserAccountId != loggedUser.Id) || (w.Id != UserId && w.UserAccountId == loggedUser.Id)).ToList();
        //    if (participants.Count() != 2)
        //        return StatusCode(400);

        //    var sender = participants.Where(w => w.UserAccountId == loggedUser.Id).FirstOrDefault();
        //    var reciever = participants.Where(w => w.UserAccountId != loggedUser.Id).FirstOrDefault();
        //    if (sender == null || reciever == null)
        //        return StatusCode(400);

        //    var model = new ChatListingMessages_VM
        //    {
        //        SenderId = sender.Id,
        //        RecieverId = reciever.Id,
        //        RecieverName = reciever.Name + " " + reciever.Surname,
        //        RecieverEmail = reciever.UserAccount.Email,
        //        MessagesList = new List<ChatListingMessages_VM.Messages>()
        //    };

        //    var chat = await _context.PrivateChat.Where(w => (w.User1Id == sender.Id && w.User2Id == reciever.Id) || (w.User1Id == reciever.Id && w.User2Id == sender.Id)).FirstOrDefaultAsync();
        //    if (chat == null)
        //        return PartialView("OpenChatBox_Ajax", model);
        //    var messages = await _context.PrivateChatMessage.Where(w => w.PrivateChatId == chat.Id).Select(s => s.Message).OrderBy(o => o.SendingTime).ToListAsync();

        //    model.ChatId = chat.Id;
        //    foreach (var m in messages)
        //    {
        //        model.MessagesList.Add(new ChatListingMessages_VM.Messages
        //        {
        //            MessageContent = m.MessageContent,
        //            SenderId = m.SenderId,
        //            SendingDate = m.SendingTime
        //        });
        //    }

        //    return PartialView("OpenChatBox_Ajax", model);
        //}

        //public IActionResult GetChatParticipants(string AjaxView, string NameFilter)
        //{
        //    var loggedUser = HttpContext.GetLoggedUser();
        //    var users = _context.User
        //        .Where(w => (w.Name.Contains(NameFilter) || w.Surname.Contains(NameFilter)) && w.UserAccountId != loggedUser.Id)
        //        .Select(s => new ChatParticipants_VM
        //        {
        //            UserId = s.Id,
        //            UserName = s.Name + " " + s.Surname
        //        })
        //        .ToList();
        //    ViewData["IsGroupChat"] = "false";
        //    return PartialView(AjaxView, users); // GetChatParticipants_Ajax
        //}

        //public IActionResult GetGroupChatParticipants()
        //{
        //    var loggedUser = HttpContext.GetLoggedUser();
        //    var user = _context.User.Where(w => w.UserAccountId == loggedUser.Id).FirstOrDefault();
        //    var groups = _context.GroupChatParticipants
        //        .Where(w => w.UserId == user.Id)
        //        .Select(s => new ChatParticipants_VM
        //        {
        //            UserId = s.GroupChatId,
        //            UserName = s.GroupChat.Name
        //        })
        //        .ToList();
        //    ViewData["IsGroupChat"] = "true";
        //    return PartialView("GetChatParticipants_Ajax", groups);
        //}

        //public IActionResult CreateNewGroupChat()
        //{
        //    return PartialView();
        //}

        //public async Task<IActionResult> CreateGroupChat(string GroupName)
        //{
        //    var eGroup = await _context.GroupChat.Where(w => w.Name == GroupName).AnyAsync();
        //    if (eGroup)
        //        return StatusCode(400);

        //    var groupChat = new GroupChat
        //    {
        //        Name = GroupName,
        //        CreatingTime = DateTime.Now
        //    };
        //    var addedGroupChat = await _context.GroupChat.AddAsync(groupChat);
        //    await _context.SaveChangesAsync();

        //    var UserAccount = HttpContext.GetLoggedUser();
        //    var User = await _context.User.Where(w => w.UserAccountId == UserAccount.Id).FirstOrDefaultAsync();

        //    var groupChatParticipant = new GroupChatParticipants
        //    {
        //        UserId = User.Id,
        //        GroupChatId = addedGroupChat.Entity.Id
        //    };
        //    await _context.GroupChatParticipants.AddAsync(groupChatParticipant);
        //    await _context.SaveChangesAsync();
        //    return StatusCode(201);
        //}

        //public async Task<IActionResult> AddGroupChatParticipant(string GroupName, int UserId)
        //{
        //    var GroupChat = await _context.GroupChat.Where(w => w.Name == GroupName).FirstOrDefaultAsync();
        //    var User = await _context.User.Where(w => w.Id == UserId).FirstOrDefaultAsync();
        //    if (GroupChat == null || User == null)
        //        return StatusCode(400);

        //    var groupChatParticipant = new GroupChatParticipants
        //    {
        //        GroupChatId = GroupChat.Id,
        //        UserId = UserId
        //    };
        //    await _context.GroupChatParticipants.AddAsync(groupChatParticipant);
        //    await _context.SaveChangesAsync();
        //    return StatusCode(201);
        //}

        //public async Task RemoveGroupChatParticipant(string GroupName, int UserId)
        //{
        //    var GroupChat = await _context.GroupChat.Where(w => w.Name == GroupName).FirstOrDefaultAsync();
        //    var participation = await _context.GroupChatParticipants.Where(w => w.UserId == UserId && w.GroupChatId == GroupChat.Id).FirstOrDefaultAsync();
        //    _context.GroupChatParticipants.Remove(participation);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task SendNewMessage(int ChatId, string Message, int User2Id = 0)
        //{
        //    var loggedUser = HttpContext.GetLoggedUser();
        //    var user = _context.User.Where(w => w.UserAccountId == loggedUser.Id).FirstOrDefault();
        //    var msg = new Message
        //    {
        //        MessageContent = Message,
        //        SendingTime = DateTime.Now,
        //        SenderId = user.Id
        //    };
        //    await _context.Message.AddAsync(msg);
        //    await _context.SaveChangesAsync();

        //    PrivateChat privateChat = null;
        //    if (ChatId == 0)
        //    {
        //        privateChat = new PrivateChat
        //        {
        //            User1Id = user.Id,
        //            User2Id = User2Id
        //        };
        //        await _context.PrivateChat.AddAsync(privateChat);
        //        await _context.SaveChangesAsync();
        //    }

        //    var chatmessage = new PrivateChatMessage
        //    {
        //        MessageId = msg.Id,
        //        PrivateChatId = ChatId != 0 ? ChatId : privateChat.Id
        //    };
        //    await _context.PrivateChatMessage.AddAsync(chatmessage);
        //    await _context.SaveChangesAsync();
        //}






        //public async Task SendNewGroupMessage(int GroupChatId, string Message)
        //{
        //    var loggedUser = HttpContext.GetLoggedUser();
        //    var user = _context.User.Where(w => w.UserAccountId == loggedUser.Id).FirstOrDefault();
        //    var msg = new Message
        //    {
        //        MessageContent = Message,
        //        SendingTime = DateTime.Now,
        //        SenderId = user.Id
        //    };
        //    await _context.Message.AddAsync(msg);
        //    await _context.SaveChangesAsync();

        //    _context.GroupChatMessage.Add(new GroupChatMessage
        //    {
        //        GroupChatId = GroupChatId,
        //        MessageId = msg.Id
        //    });
        //    await _context.SaveChangesAsync();
        //}

        //public IActionResult AddGroupChatParticipants(int GroupChatId, string Value)
        //{
        //    var model = new AddChatParticipants_VM
        //    {
        //        GroupChatId = GroupChatId,
        //        Participants = new List<AddChatParticipants_VM.Participant>()
        //    };
        //    var users = _context.GroupChatParticipants.Where(w => w.GroupChatId == GroupChatId).Select(s => s.User).ToList();
        //    model.Participants = _context.User.Where(w => !users.Contains(w) && (w.Name.Contains(Value) || w.Surname.Contains(Value))).Select(s => new AddChatParticipants_VM.Participant
        //    {
        //        Id = s.Id,
        //        Name = s.Name + " " + s.Surname
        //    }).ToList();
        //    return PartialView(model);
        //}

        //public IActionResult AddNewGroupChatParticipant(int GroupChatId, int UserId)
        //{
        //    var groupchatparticipant = new GroupChatParticipants
        //    {
        //        GroupChatId = GroupChatId,
        //        UserId = UserId
        //    };
        //    try
        //    {
        //        _context.GroupChatParticipants.Add(groupchatparticipant);
        //        _context.SaveChanges();
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(400);
        //    }
        //    return Ok();
        //}
    }
}
