using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public enum Gender {male, female}
    public partial class StudentInfo
    {
        //StudentID,Name,Gender,DOB, Mobile, Physics, Chemistry, Maths Marks
        private static int s_studentID = 1000;
        public string StudentID { get; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string DOB { get; set; }
        public long Mobile { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
    }
}