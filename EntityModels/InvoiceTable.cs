using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class InvoiceTable
    {         
        [ForeignKey(nameof(InvoiceId))]
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

        public int Row { get; set; }
        public int Column { get; set; }
            
        public string Value { get; set; }   
    }
}
