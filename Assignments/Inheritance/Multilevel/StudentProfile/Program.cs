using System;
namespace StudentProfile;

class Program
{
    public static void Main(string[] args)
    {
        HSCDetails hsc = new HSCDetails("Rishi","padmanaban",8907657432,"rishi@gmail","21/01/2001",Gender.male,12,"chennai",2018,100,98,78);
        hsc.GetDetails();
        hsc.ShowInfo();
        hsc.GetMarks();
        hsc.ShowMarksheet();
    }
}