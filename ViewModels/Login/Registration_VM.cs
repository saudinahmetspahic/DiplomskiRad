using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels.Login
{
    public class Registration_VM
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }   
        public bool IsAdmin { get; set; }
        public List<Tuple<int, string>> Admins { get; set; }    
        public List<PersonalPurchase> Purchases { get; set; }    

        public class PersonalPurchase
        {
            public int Id { get; set; }
            public DateTime Created { get; set; }
            public bool IsCreator { get; set; }
            public string ProgramName { get; set; }
                
        }
    }
}   
