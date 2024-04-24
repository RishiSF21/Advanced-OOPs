using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinearSearch
{
    public class SearchChar
    {
        public static void SearchCharacter(string key)
        {
            string cIDs = "c,a,f,b,k,h,j,I,i,z,t,m,p,l,d";
            string [] stringArray = cIDs.Split(",");
            // string[] arr = new string[stringArray.Length];


            bool isFound = true;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i]==key)
                {
                    isFound = false;
                    Console.WriteLine($"Character {key} was found in the index position -> {i}");
                }
            }
            if (isFound)
            {
                Console.WriteLine($"Character not found");
            }
        }
    }
}