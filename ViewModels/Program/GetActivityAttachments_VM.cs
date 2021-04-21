using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EntityModels;

namespace WebApp.ViewModels.Program
{
    public class GetActivityAttachments_VM
    {
        public int Day { get; set; }
        public int ActivityId { get; set; }
        public int Id { get; set; } 
        public TypeOfAttachment TypeOfAttachment { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double PriceToVisit { get; set; }
        public string ImageName { get; set; }
        public bool AllowModifications { get; set; }
    }
}
