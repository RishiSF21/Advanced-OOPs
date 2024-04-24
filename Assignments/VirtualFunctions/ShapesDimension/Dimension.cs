using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapesDimension
{
    public class Dimension
    {
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double Area { get; set; }

        public Dimension(double v1, double v2)
        {
            Value1 = v1;
            Value2 = v2;
        }

        public virtual double Calculate()
        {
            Area = Value1*Value2;
            return Area;
        }

        public virtual void DisplayArea()
        {
            Console.WriteLine("\nArea of Parent Class-> "+Calculate());
        }
    }
}