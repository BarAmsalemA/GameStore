using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore_IL.Models
{
    public class Customer: User
    {
        public DateTime Subscription_Date { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Postcode { get; set; }
        
    }
}
