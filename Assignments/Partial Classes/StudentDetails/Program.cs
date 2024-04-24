using System;
namespace StudentDetails;

class Program{
    public static void Main(string[] args)
    {
        StudentInfo student = new StudentInfo("Rishi",Gender.male,"21/01/2001",7689096543,100,96,67);
        student.Display();
        student.Calculate();
    }
}