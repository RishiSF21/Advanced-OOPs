using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outside;

namespace Inside
{
    public class First : Third
    {
        private int _privateNumber = 10;
        public int PrivateOut { get{return _privateNumber;} }
        public int PublicNumber = 21;
        protected int ProtectedNumber = 26;
        public int ProtectedInternalOut { get{return IProtected;} }
    }
}