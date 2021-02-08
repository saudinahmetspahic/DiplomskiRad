using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class GroupChat  
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public DateTime CreatingTime { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
