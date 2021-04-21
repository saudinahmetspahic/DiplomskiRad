using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Administration
{
    public class PurchasesOptions_VM
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Creator { get; set; }
        public string ProgramName { get; set; }
        public int ParticipantsCount { get; set; }
    }
}
