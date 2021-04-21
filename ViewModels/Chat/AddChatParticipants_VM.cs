using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Chat
{
    public class AddChatParticipants_VM
    {
        public int GroupChatId { get; set; }
        public List<Participant> Participants { get; set; }
        public class Participant
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }      
}
