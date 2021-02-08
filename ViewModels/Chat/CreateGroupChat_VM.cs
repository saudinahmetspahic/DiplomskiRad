using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Chat
{
    public class CreateGroupChat_VM
    {
        public string GroupChatName { get; set; }
        public List<ChatParticipants> Participants { get; set; }
        public class ChatParticipants
        {
            public int UserId { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
        }
    }
}
