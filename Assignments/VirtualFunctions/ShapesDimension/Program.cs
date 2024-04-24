using System;
namespace ShapesDimension;

class Program
{
    public static void Main(string[] args)
    {
        Rectangle shape1 = new Rectangle(20,10);
        shape1.DisplayArea();

        Sphere shape2 = new Sphere(20,10,32);
        shape2.DisplayArea();
    }
}