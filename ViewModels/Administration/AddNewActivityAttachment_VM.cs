using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EntityModels;

namespace WebApp.ViewModels.Administration
{
    public class AddNewActivityAttachment_VM
    {
        public int ActivityId { get; set; }
        public List<SelectListItem> TypeOfAttachmentSelect { get; set; }
        public TypeOfAttachment TypeOfAttachment { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double PriceToVisit { get; set; }
        public IFormFile Image { get; set; }
    }
}
