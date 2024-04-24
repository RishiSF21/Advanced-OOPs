using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryShop
{
    //Enum declaration
    public enum Gender {Select, Male, Female}
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string MailID { get; set; }

        //Constructor
        public PersonalDetails(string name, string father, Gender gender, long mobile,DateTime dob, string mailID)
        {
            Name = name;
            FatherName = father;
            Gender = gender;
            Mobile = mobile;
            DOB = dob;
            MailID = mailID;
        }
    }
}