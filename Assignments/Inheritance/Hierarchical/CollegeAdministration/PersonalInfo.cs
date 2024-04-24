using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdministration
{
    //Enum declaration
    public enum Gender {select, male, female}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long PhoneNo { get; set; }
        public string MailID { get; set; }
        public string DOB { get; set; }
        public Gender Gender { get; set; }

        //Constructor
        public PersonalInfo(string name, string fatherName, long phoneNo, string mailID, string dob, Gender gender){
            Name = name;
            FatherName = fatherName;
            PhoneNo = phoneNo;
            MailID = mailID;
            DOB = dob;
            Gender = gender;
        }
    }
}