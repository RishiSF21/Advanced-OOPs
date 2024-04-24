using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public enum Gender {male, female}
    public partial class EmployeeDetails
    {
        //EmployeeID,Name,Gender,DOB, Mobile
        private static int s_employeeID = 1000;
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string DOB { get; set; }
        public long Mobile { get; set; }
    }
}