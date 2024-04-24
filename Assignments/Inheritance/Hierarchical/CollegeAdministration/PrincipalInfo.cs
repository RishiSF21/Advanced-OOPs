using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdministration
{
    public class PrincipalInfo : PersonalInfo
    {
        //PrincipalID, Qualification, YearOfExperience, DateOfJoining
        private static int s_principalID = 1110;
        public string PrincipalID { get; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateOnly DateOfJoining { get; set; }

        //Constructor
        public PrincipalInfo(string name, string fatherName, long phoneNo, string mailID, string dob, Gender gender,string qualification, int yearOfExp, DateOnly doj) : base(name, fatherName, phoneNo, mailID, dob, gender)
        {
            s_principalID++;
            PrincipalID = "PID" + s_principalID;
            Qualification = qualification;
            YearOfExperience = yearOfExp;
            DateOfJoining = doj;
        }

        public void ShowDetails(){
            Console.WriteLine($"\t\t************ Principal Details ************\nName : {Name}\nFather Name : {FatherName}\nPhone No : {PhoneNo}\nMail ID : {MailID}\nDOB : {DOB}\nGender : {Gender}\nPrincipal ID : {PrincipalID}\nQualification : {Qualification}\nYears of Experience : {YearOfExperience}\nDOJ: {DateOfJoining}");
        }
    }
}