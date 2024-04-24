using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class Marksheet : Theory,ICalculate
    {
        private int s_marksheetNo = 2000;
        public string MarksheetNo { get; }
        public DateTime DateOfIssues { get; set; }
        public int Total { get; set; }
        public double Percentage { get; set; }
        public int ProjectMark { get; set; }

        public Marksheet(int regNo, string name, string father, string phone, DateTime dob, Gender gender, DateTime doi, int projectMark) : base (regNo,name,father,phone,dob,gender)
        {
            s_marksheetNo++;
            MarksheetNo = "MNO" + s_marksheetNo;
            DateOfIssues = doi;
            ProjectMark = projectMark;
        }
        public void CalculateUG()
        {
            int sem_1 = 0, sem_2 = 0, sem_3 = 0, sem_4 = 0, sem_5 = 0, sem_6 = 0;
            double sem1Percentage = 0, sem2Percentage = 0, sem3Percentage = 0, sem4Percentage = 0, sem5Percentage = 0, sem6Percentage = 0;
            foreach(int marks in sem1)
            {
                sem_1 += marks;
            }
            sem1Percentage = sem_1/6;
            foreach(int marks in sem2)
            {
                sem_2 += marks;
            }
            sem2Percentage = sem_2/6;
            foreach(int marks in sem3)
            {
                sem_3 += marks;
            }
            sem3Percentage = sem_3/6;
            foreach(int marks in sem4)
            {
                sem_4 += marks;
            }
            sem4Percentage = sem_4/6;
            foreach(int marks in sem5)
            {
                sem_5 += marks;
            }
            sem5Percentage = sem_5/6;
            foreach(int marks in sem6)
            {
                sem_6 += marks;
            }
            sem6Percentage = sem_6/6;
            Total = sem_1 + sem_2 + sem_3 + sem_4 + sem_5 + sem_6;
            Percentage = (sem1Percentage+sem2Percentage+sem3Percentage+sem4Percentage+sem5Percentage+sem6Percentage)/36;

            Console.WriteLine("{RegNo} | {Name} | {FatherName} | {Phone} | {DOB} | {Gender} | {DateOfIssue} | {Total} | {Percentage} | {ProjectMark}");
            Console.WriteLine($"{RegistationNumber} | {Name} | {FatherName} | {Phone} | {DOB} | {Gender} | {DateOfIssues} | {Total} | {Percentage} | {ProjectMark}");
        }

        public void ShowMarksheet()
        {
            CalculateUG();
        }
    }
}