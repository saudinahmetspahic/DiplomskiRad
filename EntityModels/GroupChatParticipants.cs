using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class GroupChatParticipants
    {
        [ForeignKey(nameof(UserId))]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(GroupChatId))]
        public int GroupChatId { get; set; }
        public GroupChat GroupChat { get; set; }
    }
}
