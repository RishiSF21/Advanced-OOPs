using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarchical
{
    public class CustomerDetails : PersonalDetails
    {
        private static int s_custID = 201;
        public string CustomerID { get; set; }
        public double Balance { get; set; }

        public CustomerDetails(string userID, string name, string fatherName, Gender gender, long phone, double balance) : base(userID, name, fatherName, gender, phone)
        {
            s_custID++;
            CustomerID = "CID" + s_custID;
            Balance = balance;
        }
    }
}