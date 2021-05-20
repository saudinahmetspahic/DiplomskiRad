using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class ProgramActivity
    {
        public int Id { get; set; } 

        [ForeignKey(nameof(ProgramId))]
        public int ProgramId { get; set; }
        public Program Program { get; set; }

        public int DayOfProgram { get; set; }
        public DateTime Start { get; set; } 
        public int DedicatedHours { get; set; }

        [ForeignKey(nameof(ActivityId))]
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }  
    }
}
