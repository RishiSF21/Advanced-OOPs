using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount
{
    public class AccountInfo : PersonalInfo
    {
        //AccountNumber, BranchName, IFSCCode, Balance
        private static int s_accountNo = 1150; //Read-Only field
        public string AccountNumber { get; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public double Balance { get; set; }

        //constructor
        public AccountInfo(string name, string fatherName, long phoneNo, string mailID, string dob, Gender gender, string branch, string ifsc, double balance) : base(name, fatherName, phoneNo, mailID, dob, gender)
        {
            s_accountNo++;
            AccountNumber = "SBI" + s_accountNo;
            BranchName = branch;
            IFSCCode = ifsc;
            Balance = balance;
        }

        // ShowAccountInfo
        public void ShowAccountInfo()
        {
            Console.WriteLine($"\n\t\t************ {Name}'s Account Details ************\nName : {Name}\nFather Name : {FatherName}\nPhone No : {PhoneNo}\nMail ID : {MailID}\nDOB : {DOB}\nGender : {Gender}\nAccount No : {AccountNumber}\nBranch : {BranchName}\nIFSC COde : {IFSCCode}\nAccount Balance : {Balance}");

        }//ShowAccountInfo Ends

        //Deposit
        public void Deposit()
        {
            Console.Write("\n\n************ Deposit ************ \n\nEnter Deposit Amount -> ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Balance += amount;
            Console.WriteLine("\n\t\t************ Amount Credited to your bank account successfully !! ************");
        }//Deposit Ends

        //Withdraw
        public void Withdraw()
        {
            Console.Write("\n\n************ Cash Withdrawal ************ \n\nEnter Amount to withdraw -> ");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
            Balance -= withdrawAmount;
            Console.WriteLine("\n\t\t************ Cash Withdrawal successfull !! ************");
        }//Withdraw Ends

        //ShowBalance
        public void ShowBalance()
        {
            Console.Write("\n\n************ Account Balance ************ \n\n");
            Console.WriteLine($"Your Account Balance -> {Balance}");
        }//ShowBalance Ends
    }
}