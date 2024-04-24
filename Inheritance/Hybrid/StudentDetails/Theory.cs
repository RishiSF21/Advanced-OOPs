using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class Theory : PersonalInfo
    {
        public List<int> sem1 = new List<int>(){90,89,56,67,100,78};
        public List<int> sem2 = new List<int>(){70,99,80,74,90,58};
        public List<int> sem3 = new List<int>(){95,69,66,77,70,98};
        public List<int> sem4 = new List<int>(){100,72,71,89,65,70};
        public List<int> sem5 = new List<int>(){81,67,58,47,50,100};
        public List<int> sem6 = new List<int>(){99,80,82,88,87,49};
        public Theory(int regNo, string name, string father, string phone, DateTime dob, Gender gender) : base (regNo,name,father,phone,dob,gender)
        {
            
        }
    }
}