using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryShop
{
    public class CustomerDetails : PersonalDetails, IBalance
    {
        private static int s_customerID = 1000;
        public string CustomerID { get; }
        private double _balance;
        public double WalletBalance { get{return _balance;} }
        //Constructor
        public CustomerDetails(string name, string father, Gender gender, long mobile, DateTime dob,string mailID,  double walletBalance) : base(name, father, gender, mobile, dob, mailID)
        {
            s_customerID++;
            CustomerID = "CID" + s_customerID;
            _balance += walletBalance;
        }

        public CustomerDetails(string customerID, string name, string father, Gender gender, long mobile, DateTime dob, string mailID, double walletBalance) : base(name, father, gender, mobile,dob, mailID)
        {
            CustomerID = "CID" + s_customerID;
            _balance += walletBalance;
        }
        public void WalletRecharge(double amount)
        {
            _balance += amount; 
        }

        public void DeductAmount(double amount)
        {
            _balance -= amount; 
        }

    }
}