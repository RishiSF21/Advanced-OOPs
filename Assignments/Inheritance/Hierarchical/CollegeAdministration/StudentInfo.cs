using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdministration
{
    public class StudentInfo : PersonalInfo
    {
        // StudentID, Degree, Department, semester
        private static int s_studentID = 2000;
        public string StudentID { get; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public int Semester { get; set; }

        //Constructor
        public StudentInfo(string name, string fatherName, long phoneNo, string mailID, string dob, Gender gender,string degree, string department,int semester) : base(name, fatherName, phoneNo, mailID, dob, gender)
        {
            s_studentID++;
            StudentID = "SID" + s_studentID;
            Degree = degree;
            Department = department;
            Semester = semester;
            
        }

        public void ShowDetails(){
            Console.WriteLine($"\t\t************ Student Details ************\nName : {Name}\nFather Name : {FatherName}\nPhone No : {PhoneNo}\nMail ID : {MailID}\nDOB : {DOB}\nGender : {Gender}\nStudent ID : {StudentID}\nDegree : {Degree}\nDepartment : {Department}\nSemester: {Semester}");
        }
    }
}