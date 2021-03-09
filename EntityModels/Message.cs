using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class Message
    {
        public int Id { get; set; }
        public DateTime SendingTime { get; set; }
        public string MessageContent { get; set; } 


        [ForeignKey(nameof(SenderId))]
        public int SenderId { get; set; }   
        public User Sender { get; set; }

    }
}
    