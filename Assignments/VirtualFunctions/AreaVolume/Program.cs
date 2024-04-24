using System;
using AreaVolume;
namespace VirtualFunctions;
class Program
{
    public static void Main(string[] args)
    {
        VolumeCalculator volume = new VolumeCalculator();
        volume.Display();

        AreaCalculator area = new AreaCalculator();
        area.Display();
    }
}