using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Program
{
    public class CreateCustomProgram_VM
    {
        public string ProgramName { get; set; }
        public List<Day> Days { get; set; }


        public class Day
        {
            public int NumberOfDay { get; set; }
            public List<Activity> Activities { get; set; }
        }
            
        public class Activity
        {
            public int ActivityId { get; set; }
            public List<Attachment> Attachments { get; set; }
        }

        public class Attachment
        {
            public int AttachmentId { get; set; }
        }


        public List<OldProgram> OldPrograms { get; set; }

        public class OldProgram
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public DateTime DateCreated { get; set; }   
        }
    }


}
