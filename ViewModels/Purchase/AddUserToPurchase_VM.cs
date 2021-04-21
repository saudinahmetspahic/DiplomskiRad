using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Purchase
{
    public class AddUserToPurchase_VM
    {
        public int PurchaseId { get; set; }

        public List<User> Users { get; set; }
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

    }
}
