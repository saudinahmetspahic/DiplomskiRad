using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Purchase
{
    public class AttachInvoice_VM   
    {
        public List<SelectListItem> PurchasesList { get; set; }
        public int PurchaseId { get; set; }
        public int InvoiceId { get; set; }
    }
}
