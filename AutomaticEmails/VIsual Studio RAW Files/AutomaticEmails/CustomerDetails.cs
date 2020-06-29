using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticEmails
{
    class CustomerDetails
    {
        public int CustomerID { get; set; }
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public decimal PhoneNo { get; set; }
        public CustomerDetails(int id, string email, string fname, string lName, decimal phoneNo    )
        {
            this.CustomerID = id;
            this.EmailAddress = email;
            this.Name = fname + " " + lName;
            this.PhoneNo = phoneNo;
        }
    }
}
