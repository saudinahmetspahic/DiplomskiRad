using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Administration
{
    public class AddNewActivity_VM
    {
        public string Title { get; set; }   
        public string Description { get; set; }
        public IFormFile Image { get; set; }
    }
}
    