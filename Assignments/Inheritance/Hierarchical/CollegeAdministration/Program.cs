using System;
using System.Text.Json.Serialization.Metadata;
namespace CollegeAdministration;

class Program
{
    public static void Main(string[] args)
    {
        TeacherInfo teacher1 = new TeacherInfo("John Durairaj","Joseph",7397688949,"jd@gmail","21/01/2001",Gender.male,"ECE","Physics","MTECH",10,new DateOnly(2019,09,12));
        TeacherInfo teacher2 = new TeacherInfo("James","Paulraj",9877688949,"james@gmail","20/03/2001",Gender.male,"EEE","Electronics Engineering","MS",16,new DateOnly(2022,09,12));

        StudentInfo student1 = new StudentInfo("Rishi","Padmanaban",7397688949,"rishi@gmail","26/12/2000",Gender.male,"MCA","Computer Science",4);
        StudentInfo student2 = new StudentInfo("Parkavi","Raj",6897688949,"paru@gmail","26/01/2001",Gender.female,"MCA","Computer Science",3);

        PrincipalInfo principal = new PrincipalInfo("Xavier","Francis",9028709432,"xavi@gmail","10/10/1976",Gender.male,"MCA,MBA",24,new DateOnly(2015,07,03));

        teacher1.ShowDetails();
        teacher2.ShowDetails();

        student1.ShowDetails();
        student2.ShowDetails();

        principal.ShowDetails();

    }
}