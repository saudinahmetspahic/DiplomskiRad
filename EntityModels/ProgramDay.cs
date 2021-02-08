using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class ProgramDay
    {
        public int Id { get; set; }
        public int NumberOfDay { get; set; }
        public DateTime Date_Day { get; set; }
        public bool IsOver { get; set; }    
    }
}
