using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class PurchaseParticipants
    {

        [ForeignKey(nameof(ParticipantId))]
        public int ParticipantId { get; set; }
        public User Participant { get; set; }

        [ForeignKey(nameof(PurchaseId))]
        public int PurchaseId { get; set; }
        public Purchase Purchase { get; set; }

        public DateTime Arrival { get; set; }      
        public int ParticipantGroup { get; set; }
    }
}
