using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Administration
{
    public class GetProgramDetails_VM
    {
        public ProgramsOptions_VM ProgramDetails { get; set; }

        public int NumberOfSells { get; set; }
        public DateTime DateStateChanged { get; set; }
        public DateTime DateAccessChanged { get; set; }
        public double ProgramPriceExpected { get; set; }    
        public double TotalPriceOfSellsExpected { get; set; }

        public List<_Activity> Activities { get; set; }    
        public class _Activity
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public int DayOfProgram { get; set; }
            public string ImageName { get; set; }
            public List<_Attachment> Attachments { get; set; }   
        }
            
        public class _Attachment    
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string ImageName { get; set; }
            public double Price { get; set; }   
        }
    }
}
