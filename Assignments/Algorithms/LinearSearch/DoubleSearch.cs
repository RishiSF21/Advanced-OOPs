using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinearSearch
{
    public class DoubleSearch
    {
        public static void SearchDouble()
        {
            string numbers = "1.1,65.3,93.9,55.5,3.5,6.9";
            string[] stringArray = numbers.Split(",");
            double[] numberArray = new double[stringArray.Length];
            double key = 3.5;

            for (int i = 0; i < stringArray.Length; i++)
            {
                numberArray[i] = double.Parse(stringArray[i]);
            }

            bool isFound = true;
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] == key)
                {
                    isFound = false;
                    Console.WriteLine($"Element {key} was found in the index position -> {i}");
                }
            }
            if (isFound)
            {
                Console.WriteLine($"Element not found");
            }
        }
    }
}