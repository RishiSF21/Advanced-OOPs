using System;
namespace StudentDetails;

class Program
{
    public static void Main(string[] args)
    {
        Marksheet m1 = new Marksheet(1859,"Rishi","Padmanaban","790394885",new DateTime(2001,01,21),Gender.Male,DateTime.Now,90);
        m1.ShowMarksheet();
    }
}