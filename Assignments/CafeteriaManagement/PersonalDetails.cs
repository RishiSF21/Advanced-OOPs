using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    //Enum declaration
    public enum Gender {Select, Male, Female}
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long Mobile { get; set; }
        public string MailID { get; set; }

        //Constructor
        public PersonalDetails(string name, string father, Gender gender, long mobile, string mailID)
        {
            Name = name;
            FatherName = father;
            Gender = gender;
            Mobile = mobile;
            MailID = mailID;
        }
    }
}