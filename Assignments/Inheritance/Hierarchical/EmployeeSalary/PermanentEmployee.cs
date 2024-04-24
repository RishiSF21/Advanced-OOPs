using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class PermanentEmployee : SalaryInfo
    {
        //EmployeeID, Employee Type, DA=0.2% of basic, HRA= 0.18% of basic, PF – 0.1 % basic, Total Salary
        private static int s_employeeID = 4000;
        public string EmployeeID { get; }
        public string EmployeeType { get; set; }
        public double DA { get; set; }
        public double HRA { get; set; }
        public double PF { get; set; }

        //Constructor
        public PermanentEmployee(double basic, int month, string employeeType) : base( basic, month)
        {
            s_employeeID++;
            EmployeeID = "EID" + s_employeeID;
            EmployeeType = employeeType;
            TotalSalary();
        }

        //Methods
        public double TotalSalary()
        {
            DA = BasicSalary * 0.2;
            HRA = BasicSalary * 0.18;
            PF = BasicSalary * 0.1;
            BasicSalary += DA + HRA - PF;
            return BasicSalary;
        }

        public void ShowSalary()
        {
            Console.WriteLine($"\n\nEmployee ID : {EmployeeID}\nEmployee Type : {EmployeeType}\nTotal Salary -> {BasicSalary}");
        }
    }
}