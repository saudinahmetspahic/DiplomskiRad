using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class GroupChatMessage
    {
        [ForeignKey(nameof(MessageId))]
        public int MessageId { get; set; }
        public Message Message { get; set; }

        [ForeignKey(nameof(GroupChatId))]
        public int GroupChatId { get; set; }
        public GroupChat GroupChat { get; set; }
    }
}
