using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Program
{
    public class RateProgram_VM
    {
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public List<RateActivity> Activities { get; set; }
        public class RateActivity
        {
            public int ActivityId { get; set; }
            public string Image { get; set; }
            public string Description { get; set; }
            public double? CurrentRate { get; set; }    
            public int GivenRate { get; set; }  

        }

    }
}
