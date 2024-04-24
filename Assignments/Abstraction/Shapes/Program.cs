using System;
namespace Shapes;

class Program{
    public static void Main(string[] args)
    {
        Cylinder cylinderShape = new Cylinder(20,10);
        cylinderShape.CalculateArea();
    }
}