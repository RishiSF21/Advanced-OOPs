using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryShop
{
    public partial class CustomList<Type>
    {
        private int _count;
        private int _capacity;
        public int Count { get{return _count;} }
        public int Capacity { get{return _capacity;} }
        private Type[] _array;
        public Type this[int index]{ get{return _array[index];} set{_array[index] = value;}}
    }
}