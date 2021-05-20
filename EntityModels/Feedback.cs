using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }   

        [ForeignKey(nameof(CreatorId))]
        public int CreatorId { get; set; }
        public User Creator { get; set; }

        [ForeignKey(nameof(ProgramId))]
        public int ProgramId { get; set; }
        public Program Program { get; set; }
    }
}
