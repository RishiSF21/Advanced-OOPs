using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public partial class EmployeeDetails
    {
        public EmployeeDetails(string name, Gender gender, string dob, long mobile)
        {
            s_employeeID++;
            EmployeeID = "EID" + s_employeeID;
            Name = name;
            Gender = gender;
            DOB = dob;
            Mobile = mobile;
        }
    }
}