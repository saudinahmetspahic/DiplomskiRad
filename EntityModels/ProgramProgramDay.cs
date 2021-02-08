using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class ProgramProgramDay
    {
        [ForeignKey(nameof(ProgramId))]
        public int ProgramId { get; set; }
        public Program Program { get; set; }

        [ForeignKey(nameof(ProgramDayId))]
        public int ProgramDayId { get; set; }
        public ProgramDay ProgramDay { get; set; }
    }
}
