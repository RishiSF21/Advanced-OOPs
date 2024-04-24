using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        //non abstract properties - Radius, Height, Side
        //abstract properties - Area, Volume
        //protected double _area;
        public abstract double Area { get; set; }
        public abstract double Volume {get; set;}
        //protected double _volume;
        public double Radius { get; set; }
        public double Height { get; set; }
        public double Side { get; set; }

        //Abstract Methods
        public abstract void CalculateArea();
        public abstract void CalculateVolume();
    }
}