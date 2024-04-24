using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking
{
    public class IDInfo : PersonalInfo
    {
        private static int s_voterID = 1000;
        private static long s_aadhar = 895109094933;
        public string VoterID { get; set; }
        public long AadharNo { get; set; }
        public string PanNo {get; set;}
        public IDInfo(string name, Gender gender, DateTime dob, string mobile, string pan) : base(name,gender,dob,mobile)
        {
            s_voterID++;
            s_aadhar++;
            VoterID = "VID"+s_voterID;
            AadharNo = s_aadhar;
            PanNo = pan;
        }
    }
}