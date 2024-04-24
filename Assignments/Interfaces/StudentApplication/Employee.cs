using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApplication
{
    public class Employee
    {
        private string _employeeID;
        public string EmployeeID { get{return _employeeID;} }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        public void Display(string sID, string name, string father, string mobile)
        {
            _employeeID =sID;
            Name = name;
            FatherName = father;
            Mobile = mobile;
            Console.WriteLine($"\nName : {Name}\nStudent ID : {EmployeeID}\nFather Name : {FatherName}\nMobile : {Mobile}");
        }
    }
}