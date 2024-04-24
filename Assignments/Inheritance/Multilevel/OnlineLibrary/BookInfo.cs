using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public class BookInfo : RackInfo
    {
        //BookID, BookName, AuthorName, Price
        private static int s_bookID = 1001;
        public string BookID { get; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }

        public BookInfo(string department, string degree, int columnNo, string bookName, string author, double price) : base(department, degree, columnNo)
        {
            s_bookID++;
            BookID = "BID" + s_bookID;
            BookName = bookName;
            AuthorName = author;
            Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\n\t\t********** Online Library **********\nDepartment : {DepartmentName}\nDegree : {Degree}\nBook Name : {BookName}\nBook ID : {BookID}\nRack No : {RackNumber}\nColumn No : {ColumnNumber}\nAuthor : {AuthorName}\nPrice : {Price}");
        }
    }
}