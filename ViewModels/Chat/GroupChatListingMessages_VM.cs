using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Chat
{
    public class GroupChatListingMessages_VM
    {
        public int UserId { get; set; } 
        public string GroupName { get; set; }
        public List<string> Participants { get; set; }
        public List<Message> Messages { get; set; }
        public class Message
        {
            public int SenderId { get; set; }
            public string SenderName { get; set; }
            public DateTime SendingDate { get; set; }
            public string MessageContent { get; set; }
        }
    }
}
