using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public enum Gender {Male, Female}
    public class PersonalInfo
    {
        //RegistationNumber, Name, FatherName, Phone, DOB, Gender
        public int RegistationNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }

        public PersonalInfo(int regNo, string name, string father, string phone, DateTime dob, Gender gender)
        {
            RegistationNumber = regNo;
            Name = name;
            FatherName = father;
            Phone = phone;
            DOB = dob;
            Gender = gender;
        }

    }
}