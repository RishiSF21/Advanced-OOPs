using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public class UserDetails : PersonalDetaills,IWallet
    {
        private static int s_userID = 1000;
        public string UserID { get;  }
        private int _balance;
        public int WalletBalance { get{ return _balance; } }

        //Constructor
        public UserDetails(string name, int age, string city, string phone, int balance) : base (name, age, city, phone)
        {
            s_userID++;
            UserID = "UID" + s_userID;
            Name = name;
            Age = age;
            City = city;
            PhoneNumber = phone;
            _balance = balance;
        }

        //Interface Methods
        public void WalletRecharge(int amount)
        {
            _balance += amount;
        }
        public void DeductBalance(int amount)
        {
            _balance -= amount;
        }
    }
}