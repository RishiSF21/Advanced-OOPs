using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public class PersonalDetaills
    {
    //      Name
    // •	Age
    // •	City
    // •	PhoneNumber
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public PersonalDetaills(string name, int age, string city, string phone){
            Name = name;
            Age = age;
            City = city;
            PhoneNumber = phone;
        }

    }
}