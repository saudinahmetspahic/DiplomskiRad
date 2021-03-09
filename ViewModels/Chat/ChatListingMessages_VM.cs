using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Chat
{
    public class ChatListingMessages_VM
    {
        public int ChatId { get; set; }
        public int SenderId { get; set; }
        public int RecieverId { get; set; }
        public string RecieverName { get; set; }
        public string RecieverEmail { get; set; }
        public List<Messages> MessagesList { get; set; }
        public class Messages
        {
            public DateTime SendingDate { get; set; }
            public int SenderId { get; set; }
            public string MessageContent { get; set; }
        }
    }
}
