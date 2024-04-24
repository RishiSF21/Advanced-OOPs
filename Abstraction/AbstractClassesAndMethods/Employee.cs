using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassesAndMethods
{
    public abstract class Employee //abstract class
    {
        //Abstract class - partial abstraction
        //It has fields, properties, methods, constructor, destructor, events
        //can have both abstract declaration and normal definitions
        //can only used with an inherited class
        //Not support multiple inheritance
        //It cannot be static class
        protected string _name; //Normal Fields
        public abstract string Name { get; set; } //Abstract property
        public double Amount { get; set; } //Normal Fields
        public string Display() //Normal Method
        {
            return _name;
        }
        public abstract double Salary(int dates); //Abstract method - Only Declaration
    }
}