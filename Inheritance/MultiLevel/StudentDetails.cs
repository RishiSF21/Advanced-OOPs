using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multilevel
{
    public class StudentDetails : PersonalDetails
    {
        private static int s_studentID = 300;
        public string StudentID { get; }
        public string Standard { get; set; }
        public string YearOfAdmission { get; set; }

        public StudentDetails(string userID, string name, string fatherName, Gender gender, long phone, string standard, string year) : base(userID, name, fatherName, gender, phone)
        {
            s_studentID++;
            StudentID = "VSRM"+s_studentID;
            Standard = standard;
            YearOfAdmission = year;
        }

        public StudentDetails(string studentID, string userID, string name, string fatherName, Gender gender, long phone, string standard, string year) : base(userID, name, fatherName, gender, phone)
        {
            StudentID = studentID;
            Standard = standard;
            YearOfAdmission = year;
        }
    }
}