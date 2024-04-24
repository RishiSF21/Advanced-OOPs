using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProfile
{
    public class HSCDetails : StudentDetails
    {
        public List<HSCDetails> hscList = new List<HSCDetails>();
        private static int s_marksheetNo = 3000;
        public string MarksheetNo { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public double Percentage { get; set; }

        public HSCDetails(string name, string fatherName, long phoneNo, string mailID, string dob, Gender gender, int standard, string branch, int academicYear, int physics, int chemistry, int maths) : base( name, fatherName,phoneNo,mailID, dob, gender, standard, branch,academicYear){
            s_marksheetNo++;
            MarksheetNo = "MNO" + s_marksheetNo;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }

        public void GetMarks()
        {
            Console.Write("Enter Physics mark: ");
            Physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Chemistry mark: ");
            Chemistry = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Maths mark: ");
            Maths = Convert.ToInt32(Console.ReadLine());

            HSCDetails hsc = new HSCDetails(Name,FatherName,PhoneNo,MailID,DOB,Gender,Standard,Branch,AcademicYear,Physics,Chemistry,Maths);
            hscList.Add(hsc);
            TotalPercentage();

        }

        public void TotalPercentage()
        {
            Total = Physics + Chemistry + Maths;
            Percentage = Total/3;
            Console.WriteLine($"Total : {Total}\nPercentage : {Percentage}");
        }

        public void ShowMarksheet()
        {
            Console.WriteLine($"********** Marksheet **********\nPhysics : {Physics}\nChemistry : {Chemistry}\nMaths : {Maths}\nTotal : {Total}\nPercentage : {Percentage}");
        }
    }
}