using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class PrivateChatMessage
    {
        [ForeignKey(nameof(PrivateChatId))]
        public int PrivateChatId { get; set; }
        public PrivateChat PrivateChat { get; set; }

        [ForeignKey(nameof(MessageId))]
        public int MessageId { get; set; }
        public Message Message { get; set; }
    }
}
