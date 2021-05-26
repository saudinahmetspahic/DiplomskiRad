using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Purchase
{
    public class GetPurchases_VM
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Creator { get; set; }
        public string ProgramTitle { get; set; }    
        public int Participants { get; set; }
    }
}
