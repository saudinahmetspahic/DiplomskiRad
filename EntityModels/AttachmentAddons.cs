using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public enum TypeOfAddons { CityCenter, Shopping, Restaurant, WiFi, TV, AirConditioner, Parking, Other }
    public class AttachmentAddons
    {
        public int Id { get; set; }

        [ForeignKey(nameof(AttachmentId))]
        public int AttachmentId { get; set; }   
        public ActivityAttachment Attachment { get; set; }

        public TypeOfAddons AddonType { get; set; } 
        public int Distance { get; set; }   
    }
}
