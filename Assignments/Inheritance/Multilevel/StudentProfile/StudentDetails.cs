using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProfile 
{
    public class StudentDetails : PersonalDetails
    {
        public List<StudentDetails> studentList = new List<StudentDetails>();
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

        public void GetDetails()
        {
            Console.Write("Enter your name : ");
            Name = Console.ReadLine();

            Console.Write("Enter father your name : ");
            FatherName = Console.ReadLine();

            Console.Write("Enter Mobile No : ");
            PhoneNo = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter your MailID : ");
            MailID = Console.ReadLine();

            Console.Write("DOB : ");
            DOB = Console.ReadLine();

            Console.Write("Gender : ");
            Gender = Enum.Parse<Gender>(Console.ReadLine(),true);

            StudentDetails student = new StudentDetails(Name,FatherName,PhoneNo,MailID,DOB,Gender,12,"Chennai",2018);
            studentList.Add(student);

        }

        public void ShowInfo(){
            foreach(StudentDetails student in studentList){
                Console.WriteLine($"Name : {student.Name}\nFather Name : {student.FatherName}\nPhone No : {student.PhoneNo}\nMail : {student.MailID}\nDOB : {student.DOB}\nRegister No : {student.RegisterNo}\nStandard : {student.Standard}\nBranch : {student.Branch}\nAcademic Year : {student.AcademicYear}");
            }
        }
    }
}