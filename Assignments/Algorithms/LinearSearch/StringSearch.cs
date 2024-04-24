using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinearSearch
{
    public static class StringSearch
    {
        public static void SearchString(string key)
        {
            string cIDs = "SF3023,SF3021,SF3067,SF3043,SF3053,SF3032,SF3063,SF3089,SF3062,SF3092 ";
            string[] stringArray = cIDs.Split(",");
            // string[] arr = new string[stringArray.Length];

            // for (int i = 0; i < stringArray.Length; i++)
            // {
            //     arr[i] = stringArray[i];
            // }
            bool isFound = true;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i]==key)
                {
                    isFound = false;
                    Console.WriteLine($"ID {key} was found in the index position -> {i}");
                }
            }
            if (isFound)
            {
                Console.WriteLine($"ID not found");
            }
        }
    }
}