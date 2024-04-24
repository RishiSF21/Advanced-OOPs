using System;
namespace StudentApplication;

class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student();
        student.Display("SID4634","Rishi","Padmanaban","7890654367");
        Employee employee = new Employee();
        employee.Display("SF4634","Roman","Ashwin","9876654367");
    }
}