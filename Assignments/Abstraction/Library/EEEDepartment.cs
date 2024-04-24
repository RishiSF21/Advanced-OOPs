using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class EEEDepartment : LibraryA
    {
        public override void SetBookInfo(string author, string book, string publisher, int year)
        {
            public override string AuthorName{get {return AuthorName;} set {AuthorName = value;} }
            public override string BookName { get {return BookName;} set {BookName = value;} }
            
        }

        public override void DisplayInfo()
        {
            
        }
    }
}