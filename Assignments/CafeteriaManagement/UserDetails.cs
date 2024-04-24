using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public class UserDetails : PersonalDetails,IBalance
    {
        private static int s_userID = 1000; //Read-Only field
        public string UserID { get; }
        public string WorkStationNumber { get; set; }
        private double _balance;
        public double WalletBalance { get{return _balance;}}

        //Constructor
        public UserDetails(string name, string father, Gender gender, long mobile, string mailID, string workStation, double walletBalance) : base(name, father, gender, mobile, mailID)
        {
            s_userID++;
            UserID = "SF" + s_userID;
            WorkStationNumber = workStation;
            _balance += walletBalance;
        }

        public UserDetails(string userID, string name, string father, Gender gender, long mobile, string mailID, string workStation, double walletBalance) : base(name, father, gender, mobile, mailID)
        {
            UserID = "SF" + s_userID;
            WorkStationNumber = workStation;
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