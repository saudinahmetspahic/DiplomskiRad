using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class PrivateChat
    {
        public int Id { get; set; }

        [ForeignKey(nameof(User1Id))]
        public int User1Id { get; set; }
        public User User1 { get; set; }

        [ForeignKey(nameof(User2Id))]
        public int User2Id { get; set; }
        public User User2 { get; set; }

    }
}
