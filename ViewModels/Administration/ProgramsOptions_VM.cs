using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EntityModels;

namespace WebApp.ViewModels.Administration
{
    public class ProgramsOptions_VM
    {
        public int Id { get; set; }
        public DateTime Date_Created { get; set; }
        public string Name { get; set; }
        public string Creator { get; set; }
        public ProgramAccess ProgramAccess { get; set; }
        public ProgramStatus ProgramStatus { get; set; }


    }
}
