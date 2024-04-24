using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking
{
    public enum AccountType {Savings, Salary}
    public class SavingsAccount : IDInfo,ICalculate,IBankInfo
    {
        private static long s_accountNo = 500210004567;
        public long AccountNo { get; }
        public AccountType AccountType { get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string Branch { get; set; }
        public int Balance { get; set; }

        public SavingsAccount(string name, Gender gender, DateTime dob, string mobile, string pan, AccountType accType, string bankName, string ifsc, string branch) : base(name,gender,dob,mobile,pan)
        {
            s_accountNo++;
            AccountNo = s_accountNo;
            AccountType = accType;
            BankName = bankName;
            IFSC = ifsc;
            Branch = branch;
        }
        public void Deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine("Amount deposited successfully");
        }
        public void Withdraw(int amount)
        {
            Balance -= amount;
            Console.WriteLine("Cash Withdrawal successfull");
        }
        public void BalanceCheck()
        {
            Console.WriteLine($"Balance -> {Balance}");
        }
    }
}