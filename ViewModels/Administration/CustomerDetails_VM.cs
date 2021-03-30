using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Administration
{
    public class CustomerDetails_VM
    {
        public CustomersOptions_VM CustomerDetails { get; set; }
        public DateTime DateRegistered { get; set; }
        public int NumberOfPlansOredered { get; set; }
        public int NumberOfPlansCreated { get; set; }
        public int NumberOfPlansCreated_Accepted { get; set; }
        public int NumberOfPlansCreated_Refused { get; set; }
        public int NumberOfPlansCreated_OnHold { get; set; }
        public bool CurrentlyOnPlan { get; set; }
        public int NumberOfChatGroups { get; set; }
        public bool IsVIP { get; set; } 

        public List<OrderedPlan_Details> PlansOrdered_Redirection  { get; set; }
        public List<CreatedPlan_Details> PlansCreated_Redirection  { get; set; }

        public class OrderedPlan_Details
        {
            public int Id { get; set; }
            public DateTime DateOrdered { get; set; }
            public DateTime DateStart { get; set; }
            public DateTime DateFinish { get; set; }    
            public string Title { get; set; }
            public string Description { get; set; } 
            public bool ForGroup { get; set; }
            public bool Finished { get; set; }
        }
        public class CreatedPlan_Details
        {
            public int Id { get; set; }
            public DateTime DateCreated { get; set; }   
            public string Title { get; set; }
            public string Description { get; set; }
            public int NumberOfSells { get; set; }
        }
    }
}
    