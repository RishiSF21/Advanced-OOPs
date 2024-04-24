using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public interface ICalculate
    {
        int Number {get; set;} //declaration only
        int Calculate(); //method declaration

        //fully abstraction
    }
}