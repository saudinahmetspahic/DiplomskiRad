using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class AuthToken
    {
        public int ID { get; set; }
        public string Value { get; set; }

        [ForeignKey(nameof(UserAccountId))]
        public int UserAccountId { get; set; }
        public UserAccount UserAccount { get; set; }

        public DateTime Date_Created { get; set; }  
    }
}
