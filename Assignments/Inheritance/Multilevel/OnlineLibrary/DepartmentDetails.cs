using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public class DepartmentDetails
    {
        //DepartmentName, Degree
        public string DepartmentName { get; set; }
        public string Degree { get; set; }

        //Constructor
        public DepartmentDetails(string department, string degree)
        {
            DepartmentName = department;
            Degree = degree;
        }
    }
}