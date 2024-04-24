using System;
namespace Banking;

class Program
{
    public static void Main(string[] args)
    {
        SavingsAccount customer = new SavingsAccount("Rishi",Gender.Male,new DateTime(2001,01,21),"7895900949","FAJ6904",AccountType.Savings,"HDFC","HDFC48929","West Mambalam");
        SavingsAccount customer2 = new SavingsAccount("Parkavi",Gender.Female,new DateTime(2001,01,26),"7895900949","FAJ6904",AccountType.Savings,"CUB","CUB48929","East Mambalam");

        customer.Deposit(10000);
        customer.Withdraw(1000);
        customer.BalanceCheck();

        customer2.Deposit(10000);
        customer2.Withdraw(1000);
        customer2.BalanceCheck();
    }
}