using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class ActivityActivityAttachment
    {
        public int Id { get; set; }
            
        [ForeignKey(nameof(ActivityId))]
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }

        [ForeignKey(nameof(ActivityAttachmentId))]
        public int ActivityAttachmentId { get; set; }
        public ActivityAttachment ActivityAttachment { get; set; }

        public DateTime PlannedStart { get; set; }
        public DateTime PlannedFinish { get; set; }
    }
}
