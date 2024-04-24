using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal
{
    public class Duck
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string EatingHabit { get; set; }

        public void DisplayInfo(string name, string habitat, string eatingHabit)
        {
            Name = name;
            Habitat = habitat;
            EatingHabit = eatingHabit;
            Console.WriteLine($"\nName - {Name}\nHabitat - {Habitat}\nEatingHabit - {EatingHabit}");
        }

        public void DisplayName(){}
    }
}