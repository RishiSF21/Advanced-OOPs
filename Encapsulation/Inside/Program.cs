using System;
namespace Inside;

class Program{
    public static void Main(string[] args)
    {
        First obj = new First();
        Console.WriteLine(obj.PrivateOut);
        Console.WriteLine(obj.PublicNumber);
        //Console.WriteLine(obj.P);

        Second sample = new Second();
        Console.WriteLine(sample.ProtectedNumberOut);
        Console.WriteLine(sample.InternalProtected);
        Console.WriteLine(sample.ProtectedNumberOut);
    }
}