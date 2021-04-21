using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Purchase
{
    public class GetAvailablePrograms_VM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool CreatedByMe { get; set; }
        public int NumberOfSells { get; set; }
        public int NumberOfCustomersPurcheses { get; set; }
        public double ExpectedPrice { get; set; }
            
            


    }
}
