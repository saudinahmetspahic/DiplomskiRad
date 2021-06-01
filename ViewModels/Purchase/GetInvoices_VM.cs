using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Purchase
{
    public class GetInvoices_VM
    {
        public int Id { get; set; } 
        public string Customer { get; set; }
        public string CustomerCountry { get; set; }
        public string PlaceOfIssue { get; set; }
        public DateTime DateOfIssue { get; set; }
        public double Settled { get; set; }
    }
}
