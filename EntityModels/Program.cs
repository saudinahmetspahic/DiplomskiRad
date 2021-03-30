using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public enum ProgramAccess { Private, Public }
    public enum ProgramStatus { Approved, Refused, OnHold }
    public class Program
    {
        public int Id { get; set; }
        public DateTime Date_Created { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey(nameof(CreatorId))]
        public int CreatorId { get; set; }
        public User Creator { get; set; }   

        public ProgramAccess ProgramAccess { get; set; }
        public ProgramStatus ProgramStatus { get; set; }


        public DateTime ApprovedDate { get; set; }
        
        [ForeignKey(nameof(ApproverId))]    
        public int? ApproverId { get; set; }  
        public User Approver { get; set; }
    }
}
