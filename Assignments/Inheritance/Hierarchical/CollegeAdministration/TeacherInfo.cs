using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdministration
{
    public class TeacherInfo : PersonalInfo
    {
        //TeacherID, Department, Subject teaching, Qualification, YearOfExperience, DateOfJoining
        private static int s_teacherID = 100;
        public string TeacherID { get; }
        public string Department { get; set; }
        public string SubjectTeaching { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateOnly DateOfJoining { get; set; }

        //Constructor
        public TeacherInfo(string name, string fatherName, long phoneNo, string mailID, string dob, Gender gender, string department, string subjectTaking, string qualification, int yearOfExp, DateOnly doj) : base( name, fatherName, phoneNo, mailID,dob, gender)
        {
            s_teacherID++;
            TeacherID = "TID" + s_teacherID;
            Department = department;
            SubjectTeaching = subjectTaking;
            Qualification = qualification;
            YearOfExperience = yearOfExp;
            DateOfJoining = doj;
        }

        public void ShowDetails(){
            Console.WriteLine($"\t\t************ Teacher Details ************\nName : {Name}\nFather Name : {FatherName}\nPhone No : {PhoneNo}\nMail ID : {MailID}\nDOB : {DOB}\nGender : {Gender}\nTeacher ID : {TeacherID}\nDepartment : {Department}\nSubject Teaching : {SubjectTeaching}\nQualification : {Qualification}\nYears of Experience : {YearOfExperience}\nDOJ: {DateOfJoining}");
        }
    }
    
}