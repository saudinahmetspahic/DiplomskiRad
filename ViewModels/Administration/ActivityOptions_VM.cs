using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Administration
{
    public class ActivityOptions_VM
    {
        public int ActivityId { get; set; }
        public string Title { get; set; }
        public int NumberOfAttachments { get; set; }
        public double ExpectedPrice { get; set; }
        public int NumberOfAppInPlans { get; set; }
        public double? Rating { get; set; }

    }
}
