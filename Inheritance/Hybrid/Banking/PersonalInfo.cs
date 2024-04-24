using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking
{
    public enum Gender {Male, Female}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Mobile { get; set; }
        
        public PersonalInfo(string name, Gender gender, DateTime dob, string mobile)
        {
            Name = name;
            Gender = gender;
            DOB = dob;
            Mobile = mobile;
        }
    }
}