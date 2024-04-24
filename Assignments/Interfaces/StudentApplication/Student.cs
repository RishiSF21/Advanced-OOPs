using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApplication
{
    public class Student : IDisplayInfo
    {
        private string _studentID;
        public string StudentID { get{return _studentID;} }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        public void Display(string sID, string name, string father, string mobile)
        {
            _studentID =sID;
            Name = name;
            FatherName = father;
            Mobile = mobile;
            Console.WriteLine($"\nName : {Name}\nStudent ID : {StudentID}\nFather Name : {FatherName}\nMobile : {Mobile}");
        }
    }
}