using System;
namespace EmployeeInfo;

class Program{
    public static void Main(string[] args)
    {
        EmployeeDetails employee1 = new EmployeeDetails("Rishi",Gender.male,"21/01/2001",78990765);
        employee1.UpdateEmployee();
        employee1.DisplayEmployee();
    }
}