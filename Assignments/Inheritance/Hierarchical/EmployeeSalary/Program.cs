using System;
namespace EmployeeSalary;

class Program{
    public static void Main(string[] args)
    {
        PermanentEmployee employee1 = new PermanentEmployee(15000,3,"Permanent");
        //employee1.TotalSalary();
        employee1.ShowSalary();

        TemporaryEmployee employee2 = new TemporaryEmployee(15000, 3,"Temporary");
        //employee2.TotalSalary();
        employee2.ShowSalary();
    }
}