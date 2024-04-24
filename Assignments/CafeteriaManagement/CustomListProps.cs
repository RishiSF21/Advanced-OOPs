using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public partial class CustomList<Type>
    {
        private int _count;
        private int _capacity;
        public int Count { get{ return _count;} }
        public int Capacity { get {return _capacity;} }

        //Creating list or array to store data
        private Type [] _array;
        
        public Type this[int index]
        {
            get {return _array[index];}
            set {_array[index] = value;}
        }

    }
}