using System;
namespace BankAccount
{
    class Program
    {
        public static void Main(string[] args)
        {
            PersonalInfo person1 = new PersonalInfo("Rishi","Padmanaban",7397688707,"rishi@gmail","21/01/2001",Gender.male);
            PersonalInfo person2 = new PersonalInfo("Parkavi","Raj Kumar",8056688707,"paru@gmail","26/12/2000",Gender.female);
            PersonalInfo person3 = new PersonalInfo("Ajith","Keshav",9394088707,"ajith@gmail","04/01/2008",Gender.male);

            AccountInfo account1 = new AccountInfo(person1.Name, person1.FatherName, person1.PhoneNo, person1.MailID, person1.DOB, person1.Gender, "West Mambalam", "IFSC12345", 5600.00);
            AccountInfo account2 = new AccountInfo(person2.Name, person2.FatherName, person2.PhoneNo, person2.MailID, person2.DOB, person2.Gender, "Anna Nagar", "IFSC10340", 30650.00);
            AccountInfo account3 = new AccountInfo(person3.Name, person3.FatherName, person3.PhoneNo, person3.MailID, person3.DOB, person3.Gender, "Vadapalani", "IFSC22305", 1200.00);
            
            account1.ShowAccountInfo();
            account1.Deposit();
            account1.Withdraw();
            account1.ShowBalance();

            account2.ShowAccountInfo();
            account2.Deposit();
            account2.Withdraw();
            account2.ShowBalance();

            account3.ShowAccountInfo();
            account3.Deposit();
            account3.Withdraw();
            account3.ShowBalance();
        }
    }
}