using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaVolume
{
    public class AreaCalculator
    {
        public double Radius { get; set; }
        public virtual double Calculate(double radius)
        {
            Radius = radius;
            return 3.14*Radius*Radius;
        }   

        public virtual void Display()
        {
            Console.WriteLine("\nArea -> "+Calculate(12));
        }
    }
}