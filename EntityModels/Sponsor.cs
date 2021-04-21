using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public enum AreaOfInterest { Transport, Catering, Other }
    public class Sponsor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public AreaOfInterest AreaOfInterest { get; set; }      
    }
}
