﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{       

    public enum TypeOfAttachment { Place, BuildingObject, Historical, Transportation, Food };
        
    public class ActivityAttachment
    {
        public int Id { get; set; }
        public TypeOfAttachment TypeOfAttachment { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double PriceToVisit { get; set; }
        public string ImageName { get; set; }

        [ForeignKey(nameof(ActivityId))]
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
    }   
}
