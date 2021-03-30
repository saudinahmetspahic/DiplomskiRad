using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class Rate
    {
        public int Id { get; set; }

        [ForeignKey(nameof(ActivityId))]
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }

        [ForeignKey(nameof(UserId))]
        public int UserId { get; set; }
        public User User { get; set; }
            
        public int RateValue { get; set; }
    }
}
