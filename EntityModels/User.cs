using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }


        [ForeignKey(nameof(UserAccountId))]
        public int UserAccountId { get; set; }
        public UserAccount UserAccount { get; set; }
    }
}
