using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_SCO
{
     public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Banned { get; set; }
        public string Email { get; set; }
        public string HoldDate { get; set; }

        public Customer(int id, string name, String DOB, int banned, string email)
        {
            CustomerID = id;
            Name = name;
            Age = CalcAge(DOB);
            Email = email;
        }

        public Customer(int id, string name, String holddate, string email)
        {
            CustomerID = id;
            Name = name;
            Email = email;
            HoldDate = holddate;
        }
        public int CalcAge(String DOB)
        {
            DateTime dob = DateTime.Parse(DOB);
            var today = DateTime.Now;
            var currentAge = today.Year - dob.Year;
            if (dob.Date > today.AddYears(-currentAge)) currentAge--;
            return currentAge;
        }
    }
}