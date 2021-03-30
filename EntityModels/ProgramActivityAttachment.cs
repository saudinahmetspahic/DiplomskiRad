using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class ProgramActivityAttachment
    {
        public int Id { get; set; }
            
        [ForeignKey(nameof(ProgramActivityId))]
        public int ProgramActivityId { get; set; }
        public ProgramActivity ProgramActivity { get; set; }

        [ForeignKey(nameof(ActivityAttachmentId))]
        public int ActivityAttachmentId { get; set; }
        public ActivityAttachment ActivityAttachment { get; set; }

        public DateTime PlannedStart { get; set; }
        public DateTime PlannedFinish { get; set; }
    }
}
