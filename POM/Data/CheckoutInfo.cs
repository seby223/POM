using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.Data
{
    public class CheckoutInfo
    {
        public CheckoutInfo(bool opt)
        {
            //Optionals = 
        }
        public bool Optionals { get; set; }
        public bool LoggedIn { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public int ShippingMethod { get; set; }


    }
}
