using System;
namespace StudentInfo;

class Program
{
    public static void Main(string[] args)
    {
        //Creating object for personalDetails class
        PersonalDetails person1 = new PersonalDetails("Rishi", "Padmanaban", 7397688707, "rishi@gmail", "21/01/2001", Gender.male);
        PersonalDetails person2 = new PersonalDetails("Parkavi", "Raj Kumar", 9087688707, "paru@gmail", "21/04/2001", Gender.female);

        //craeting object for StudentDetails class
        StudentDetails student1 = new StudentDetails(person1.Name, person1.FatherName, person1.PhoneNo, person1.MailID, person1.DOB, person1.Gender, 10, "Chennai", 2016);
        StudentDetails student2 = new StudentDetails(person2.Name, person2.FatherName, person2.PhoneNo, person2.MailID, person2.DOB, person2.Gender, 9, "Chennai", 2015);
        student1.StudentInformation();
        student2.StudentInformation();
    }
}