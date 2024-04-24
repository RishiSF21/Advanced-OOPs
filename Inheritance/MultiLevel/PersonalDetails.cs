using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multilevel
{
    public enum Gender {Select, Male, Female}
    public class PersonalDetails
    {
        private static int s_userID = 1000;
        public string UserID {get;}
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long PhoneNo { get; set; }

        public PersonalDetails(string name, string fatherName, Gender gender, long phone){
            s_userID++;
            UserID = "UID"+s_userID;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            PhoneNo = phone;
        }

        public PersonalDetails(string userID, string name, string fatherName, Gender gender, long phone){
    
            UserID = "UID"+s_userID;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            PhoneNo = phone;
        }

    }
}