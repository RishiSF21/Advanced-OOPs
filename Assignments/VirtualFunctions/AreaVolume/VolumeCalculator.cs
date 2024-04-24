using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaVolume
{
    public class VolumeCalculator: AreaCalculator
    {
        public double Height { get; set; }
        // public  double Radius { get; set; }
        public double Calculate(double radius, double height)
        {
            Radius = radius;
            Height = height;
            return 3.14*Radius*Radius*Height;
        }   

        public override void Display()
        {
            Console.WriteLine("\nVolume -> "+Calculate(12,20));
        }
    }
}