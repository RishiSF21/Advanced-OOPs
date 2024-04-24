using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Multilevel;

namespace MultiLevel
{
    public class EmployeeDetails : StudentDetails
    {
        private static int s_employeeID = 1000;
        public string EmployeeID { get; }
        public string Designation { get; set; }

        public EmployeeDetails(string studentID, string userID, string name, string fatherName, Gender gender, long phone, string standard, string year, string designation) : base(studentID, userID, name, fatherName, gender, phone, standard, year)
        {
            s_employeeID++;
            EmployeeID = "EID" + s_employeeID;
            Designation = designation;
        }
    }
}