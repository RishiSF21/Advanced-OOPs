using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public partial class StudentInfo
    {
        public StudentInfo(string name, Gender gender, string dob, long mobile, int phy, int che, int mat)
        {
            s_studentID++;
            StudentID = "SID" + s_studentID;
            Name = name;
            Gender = gender;
            DOB = dob;
            Mobile = mobile;
            Physics = phy;
            Chemistry = che;
            Maths = mat;
        }
    }
}