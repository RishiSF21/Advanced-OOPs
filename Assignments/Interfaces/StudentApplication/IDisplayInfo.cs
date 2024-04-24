using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApplication
{
    public interface IDisplayInfo
    {
        public void Display(string sID, string name, string father, string mobile);
    }
}