using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EntityModels;

namespace WebApp.ViewModels.Purchase
{
    public class IssueAnInvoice_VM
    {
        public Invoice Invoice { get; set; }    
        public bool AllowModifications { get; set; }
        public List<TableContent> Table { get; set; }
        public class TableContent
        {
            public int Row { get; set; }
            public int Column { get; set; }
            public string Value { get; set; }
        }
    }
}
