using System;

namespace SingleInheritance;
class Program{
    public static void Main(string[] args)
    {
        PersonalDetails person1 = new PersonalDetails("Parkavi","Rajan",Gender.Female,7397688707);
        Console.WriteLine($"Name : {person1.Name}\nFather Name : {person1.FatherName}\nGender : {person1.Gender}\nPhone No : {person1.PhoneNo}");

        StudentDetails student1 = new StudentDetails(person1.UserID, person1.Name, person1.FatherName, person1.Gender, person1.PhoneNo, "12th", "2017");
        Console.WriteLine($"\n\nName : {student1.UserID}\nFather Name : {student1.Name}");

    }
}