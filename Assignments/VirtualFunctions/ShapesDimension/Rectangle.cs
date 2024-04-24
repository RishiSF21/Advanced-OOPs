using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapesDimension
{
    public class Rectangle : Dimension
    {
        public double Length{ get; set; }
        public double Height { get; set; }
        public double Area { get; set; }

        public Rectangle(double v1, double v2):base(v1,v2)
        {
            Length = v1;
            Height = v2;
        }

    }
}