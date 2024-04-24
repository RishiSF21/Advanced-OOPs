using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cylinder : Shape
    {
        //Formula -  CalculateArea - 2 π r(r+h) , CalculateVolume π r2 h
        public override double Area { get {return Area;} set {Area = value;} }
        public override double Volume { get {return Volume;} set {Volume = value;} }
        public override void CalculateArea()
        {
            double area = 2 * Math.PI * Radius*(Radius+Height);
            Console.WriteLine(Math.Round(area,2));
        }
        public override void CalculateVolume()
        {
            double volume = Math.PI * Radius * Radius * Height;
            Console.WriteLine(Math.Round(volume,2));
        }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }
    }
}