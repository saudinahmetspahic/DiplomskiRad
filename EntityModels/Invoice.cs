using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public string CountryCityPostal { get; set; }
        public string PhoneFax { get; set; }
        public string Email { get; set; }

        public string PDVNumber { get; set; }

        public string Customer { get; set; }
        public string CustomerCountry { get; set; }

        public string EstimateNumber { get; set; }

        public string PlaceOfIssue { get; set; }
        public DateTime DateOfIssue { get; set; }


        public DateTime DateOfDelivery { get; set; }
        public double SettledInBAM { get; set; }
        public string TotalInWords { get; set; }
        public string MethodOfPayment { get; set; }
        public string DeadlineForPayment { get; set; }


        public string AccountToPay { get; set; }
        public string AdditionalBankAccount { get; set; }   

        public string Director { get; set; }

        public int TableRows { get; set; }
        public int TableColumns { get; set; }


        [ForeignKey(nameof(PurchaseId))]
        public int? PurchaseId { get; set; }
        public Purchase Purchase { get; set; }  
    }
}
