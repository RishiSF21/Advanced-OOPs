using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo
{
    public class StudentDetails : PersonalDetails
    {
        private static int _registerNo = 114159;
        public int RegisterNo { get; }
        public int Standard { get; set; }
        public string Branch { get; set; }
        public int AcademicYear { get; set; }

        //Constructor
        public StudentDetails(string name, string fatherName, long phoneNo, string mailID, string dob, Gender gender, int standard, string branch, int academicYear) : base(name, fatherName, phoneNo, mailID, dob, gender)
        {
            _registerNo++;
            RegisterNo = _registerNo;
            Standard = standard;
            Branch = branch;
            AcademicYear = academicYear;
        }

        public void StudentInformation()
        {
            Console.WriteLine($"Student Name : {Name}\nFather Name : {FatherName}\nPhone No : {PhoneNo}\nMail ID : {MailID}\nDOB : {DOB}\nGender : {Gender}\nRegister No : {RegisterNo}\nStandard : {Standard}\nBranch : {Branch}\nAcademic Year : {AcademicYear}");
        }
    }
}