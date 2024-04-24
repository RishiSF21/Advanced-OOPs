using System;
namespace ByArguments;
class Program
{
    public static void Main(string[] args)
    {
        Add(1,2);
        Add(2,5,4);
    }
    public static void Add(int a, int b, int c){
        Console.WriteLine(a+b+c);
    }

    public static void Add(int a, int b){
        Console.WriteLine(a+b);
    }
}