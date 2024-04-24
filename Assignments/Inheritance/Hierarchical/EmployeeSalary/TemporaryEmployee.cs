using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary 
{
    public class TemporaryEmployee : SalaryInfo
    {
        //EmployeeID, Employee Type, DA=0.15% of basic, HRA= 0.13% of basic, Total Salary
        private static int s_employeeID = 300;
        public string EmployeeID { get; }
        public string EmployeeType { get; set; }

        //Constructor
        public TemporaryEmployee(double basic, int month, string employeeType) : base( basic, month)
        {
            s_employeeID++;
            EmployeeID = "TEID" + s_employeeID;
            EmployeeType = employeeType;
            TotalSalary();
        }

        //Methods
        public double TotalSalary()
        {
            double da = BasicSalary * 0.15;
            double hra = BasicSalary * 0.13;
            BasicSalary += da + hra;
            return BasicSalary;
        }

        public void ShowSalary()
        {
            Console.WriteLine($"\n\nEmployee ID : {EmployeeID}\nEmployee Type : {EmployeeType}\nTotal Salary -> {BasicSalary}");
        }
    }
}