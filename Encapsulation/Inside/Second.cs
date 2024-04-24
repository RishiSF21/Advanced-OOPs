using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outside;

namespace Inside
{
    public class Second : Third
    {
        internal protected int InternalProtected = 40;
        public int ProtectedNumberOut { get{return IProtected;}}
        
    }
}