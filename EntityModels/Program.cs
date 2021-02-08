using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class Program
    {
        public int Id { get; set; }
        public DateTime Date_Created { get; set; }  
        public string Name { get; set; }
        public string Description { get; set; } 

        [ForeignKey(nameof(CreatorId))]
        public int CreatorId { get; set; }
        public User Creator { get; set; }

        public bool IsApproved { get; set; }    
    }
}
