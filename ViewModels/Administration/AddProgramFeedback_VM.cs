using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Administration
{
    public class AddProgramFeedback_VM
    {
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public string NewFB_Description { get; set; }
        public List<FB> FeedBack { get; set; }
        public class FB
        {
            public string Creator { get; set; }
            public DateTime Created { get; set; }
            public string Description { get; set; }
        }

    }
}
