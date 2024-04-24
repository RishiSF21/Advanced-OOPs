using System;
namespace OnlineLibrary;
class Program{
    public static void Main(string[] args)
    {
        BookInfo book1 = new BookInfo("EEE","Bachelors",5,"Data structures","Keenu Reeves",570);       
        BookInfo book2 = new BookInfo("MECH","Bachelors",5,"Engine Design","Alan Walker",1580);       
        BookInfo book3 = new BookInfo("MCA","Masters",5,"Networking","Dalton",870);       

        book1.DisplayInfo();
        book2.DisplayInfo();
        book3.DisplayInfo();
    }
}