using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Administration
{
    public enum ActivityOrAttachment { Activity, Attachment }
    public class AddNewPhoto_VM
    {
        public int AttachmentId { get; set; } 
        public int ActivityId { get; set; } 
        public ActivityOrAttachment ActivityOrAttachment { get; set; }
        public IFormFile Image { get; set; }
    }
}
