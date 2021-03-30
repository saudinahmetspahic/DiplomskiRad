using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Program
{
    public class GetProgramData_VM  
    {
        public int Day { get; set; }
        public int Activity { get; set; }
        public int Attachment { get; set; }
        //public List<Tuple<int, int, int>> Data { get; set; }  // day, activities, attachments
    }
}
