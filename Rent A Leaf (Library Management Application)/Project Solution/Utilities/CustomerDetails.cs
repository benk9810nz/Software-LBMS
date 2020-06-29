using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class CustomerDetails
    {
        public int CustomerID { get; set; }
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public int AccessLevel { get; set; }

        public CustomerDetails(int id, string email, string fname, string lName, int accessLevel)
        {
            this.CustomerID = id;
            this.EmailAddress = email;
            this.Name = fname + " " + lName;
            this.AccessLevel = accessLevel;
        }

        public CustomerDetails(string email, string userType, int accessLevel)
        {
            this.EmailAddress = email;
            this.Name = userType;
            this.AccessLevel = accessLevel;
        }
    }
}