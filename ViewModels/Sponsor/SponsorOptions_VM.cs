using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EntityModels;

namespace WebApp.ViewModels.Sponsor
{
    public class SponsorOptions_VM  
    {
        public SponsorToAdd NewSponsorToAdd { get; set; }
        public List<AddedSponsor> AddedSponsors { get; set; }

        public class SponsorToAdd
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public AreaOfInterest AreaOfInterest { get; set; }
            public IFormFile Image { get; set; }    
        }
        public class AddedSponsor
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public AreaOfInterest AreaOfInterest { get; set; }
            public string ImageName { get; set; }
        }

    }
}
