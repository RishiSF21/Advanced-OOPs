using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public class RackInfo : DepartmentDetails
    {
        private static int s_rackNumber = 2;
        public string RackNumber { get; set; }
        public int ColumnNumber{ get; set; }

        public RackInfo(string department, string degree, int columnNo) : base(department, degree)
        {
            s_rackNumber++;
            RackNumber = "R" + s_rackNumber;
            ColumnNumber = columnNo;
        }
    }
}