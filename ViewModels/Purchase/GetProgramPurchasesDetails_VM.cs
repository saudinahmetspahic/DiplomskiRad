using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Purchase
{   
    public class GetProgramPurchasesDetails_VM
    {
        public int PurchaseId { get; set; } 
        public int ProgramId { get; set; }
        public DateTime DateCreated { get; set; }
        public string Creator { get; set; }
        public string ProgramName { get; set; }
        public List<Participant> Participants { get; set; }
        public class Participant
        {
            public int ParticipantId { get; set; }
            public string Name { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
            public int Age { get; set; }
        }
    }
}
