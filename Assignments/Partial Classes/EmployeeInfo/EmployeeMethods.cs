using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public partial class EmployeeDetails
    {
        public void UpdateEmployee()
        {
            if(Gender.Equals(Gender.male) || Gender.Equals(Gender.female)){
                Name = "Mr. " + Name;
            }
            else{
                Name = "Ms. " + Name;
            }
        }

        public void DisplayEmployee()
        {
            Console.WriteLine($"********** Employee Details **********\nName : {Name}\nEmployee ID : {EmployeeID}\nGender : {Gender}\nDOB : {DOB}\nMobile No : {Mobile}");
        }
    }
}