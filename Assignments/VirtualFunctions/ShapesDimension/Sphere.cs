using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapesDimension
{
    public class Sphere : Dimension
    {
        public double Radius { get; set; }
        public Sphere(double v1, double v2, double radius) : base(v1,v2)
        {
            Radius = radius;
        }

        public override double Calculate()
        {
            return 4*3.14*Radius*Radius;
        }

        public override void DisplayArea()
        {
            Console.WriteLine($"Area of Sphere Class -> {Calculate()}");
        }
    }
}