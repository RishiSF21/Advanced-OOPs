using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public partial class StudentInfo
    {
        public void Calculate()
        {
            int total = Physics + Chemistry + Maths;
            int percentage = total/3;
            Console.WriteLine($"Total -> {total}\nPercentage -> {percentage}");
        }

        public void Display()
        {
            Console.WriteLine($"********** Student Details **********\n\nName : {Name}\nStudent ID : {StudentID}\nGender : {Gender}\nDOB : {DOB}\nMobile : {Mobile}\nPhysics : {Physics}\nChemistry : {Chemistry}\nMaths : {Maths}");
        }
    }
}