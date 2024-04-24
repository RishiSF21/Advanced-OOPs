using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cube : Shape
    {
         public override double Area { get {return Area;} set {Area = value;} }
        public override double Volume { get {return Volume;} set {Volume = value;} }

        public override void CalculateArea()
        {
            double area = 6 * Side * Side;
            Console.WriteLine($"Area of Cube = {Math.Round(area,2)}");
        }

        public override void CalculateVolume()
        {
            double volume = Side * Side * Side;
            Console.WriteLine($"Volume of Cube = {Math.Round(volume,2)}");
        }

        //Constructor
        public Cube(double side)
        {
           Side = side;
        }
    }
}