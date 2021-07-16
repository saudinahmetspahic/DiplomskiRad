using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EntityModels;

namespace WebApp.ViewModels.Catalog
{
    public class CatalogPreview_VM
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; } 
        public string ImageName { get; set; }
        public string Activity { get; set; }
        public int Rate { get; set; }   
        public double Price { get; set; }
        public List<Tuple<TypeOfAddons, int>> Addons { get; set; }  // int - distance (m)
    }
}
