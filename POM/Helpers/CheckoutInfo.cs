using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.Helpers
{
    public class CheckoutInfo
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; } = "3";
        public string Zip { get; set; }
        public string Country { get; set; } = "US";
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string ShippingMethod { get; set; }
        public string Category { get; set; }
        public string Product { get; set; }

    }
}
