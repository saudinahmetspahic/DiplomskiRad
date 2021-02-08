using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class ProgramDayActivity
    {
        [ForeignKey(nameof(ProgramDayId))]
        public int ProgramDayId { get; set; }
        public ProgramDay ProgramDay { get; set; }

        [ForeignKey(nameof(ActivityId))]
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
    }
}
