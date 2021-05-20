using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EntityModels;

namespace WebApp.ViewModels.Administration
{
    public class GetActivityDetails_VM
    {
        public int ActivityId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageSrc { get; set; }
        public List<Attachment> Attachments { get; set; }   

        public class Attachment
        {
            public int AttachmentId { get; set; }
            public TypeOfAttachment TypeOfAttachment { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public double PriceToVisit { get; set; }
            public string ImageSrc { get; set; }    
            public List<Tuple<TypeOfAddons, int>> Addons { get; set; }
        }
    }
}
