using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public abstract class LibraryA
    {
        private static int s_serialNumber = 1000;
        public string SerialNumber { get; }
        //Abstract Properties
        private string _author;
        public abstract string AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; }
        public abstract int Year { get; set; }
        //Constructor
        public LibraryA()
        {
            s_serialNumber++;
            SerialNumber = "LIB" + s_serialNumber;
        }
        //Abstract Methods
        public abstract void SetBookInfo(string author, string book, string publisher, int year);
        public abstract void DisplayInfo();
    }
}