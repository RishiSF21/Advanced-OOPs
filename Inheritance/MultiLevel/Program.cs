using System;
using MultiLevel;

namespace Multilevel;
class Program{
    public static void Main(string[] args)
    {
        PersonalDetails person1 = new PersonalDetails("Parkavi","Rajan",Gender.Female,7397688707);
        Console.WriteLine($"Name : {person1.Name}\nFather Name : {person1.FatherName}\nGender : {person1.Gender}\nPhone No : {person1.PhoneNo}");

        StudentDetails student1 = new StudentDetails(person1.UserID, person1.Name, person1.FatherName, person1.Gender, person1.PhoneNo, "12th", "2017");

        EmployeeDetails employee1 = new EmployeeDetails(student1.StudentID, student1.UserID, student1.Name, student1.FatherName, student1.Gender, student1.PhoneNo, student1.Standard, student1.YearOfAdmission, "Software Engineer");
    }
}