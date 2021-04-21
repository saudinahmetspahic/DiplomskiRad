using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class Notification
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }


        [ForeignKey(nameof(AuthorId))]
        public int AuthorId { get; set; }   
        public User Author { get; set; }
    }
}
