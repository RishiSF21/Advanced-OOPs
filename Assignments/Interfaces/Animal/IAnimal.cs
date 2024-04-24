using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal
{
    public interface IAnimal
    {
        //Name, Habitat, Eating Habit
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string EatingHabit { get; set; }
        public void DisplayName();
    }
}