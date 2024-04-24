using System;
namespace Animal;

class Program
{
    public static void Main(string[] args)
    {
        Dog dog1 = new Dog();
        Dog dog2 = new Dog();
        dog1.DisplayInfo("Tom","House","Plant based food");
        dog2.DisplayInfo("Jack","Roads","Pedigree");

        Duck duck1 = new Duck();
        Duck duck2 = new Duck();
        duck1.DisplayInfo("Rosey","Ponds","Plant based foods");
        duck2.DisplayInfo("Green","Rivers","Plant based foods");
    }
}