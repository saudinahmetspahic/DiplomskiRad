using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Program
{
    public class GetProgramFeedback_VM
    {
        public int Id { get; set; }

        public List<FB> FeedBack { get; set; }
        public class FB
        {   
            public string Creator { get; set; }
            public string Description { get; set; }
        }


    }
}
