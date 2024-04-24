using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class SearchString
    {
        public static void SearchID(string id)
        {
            string numInput = "SF3023,SF3021,SF3067,SF3043,SF3053,SF3032,SF3063,SF3089,SF3062,SF3092";
            string[] arr = numInput.Split(",");
            // int[] arr = new int[stringArr.Length];

            Array.Sort(arr);
            int left=0, right=arr.Length-1; 
            int lastNumber = int.Parse(id.Remove(0,2));
            
            while(left <= right)
            {
                int middle = left + (right-left)/2;
                if(arr[middle]==id)
                {
                    Console.WriteLine($"Element {id} is found in the index position {middle}");
                    break;
                }
                else if(lastNumber < int.Parse(arr[middle].Remove(0,2)))
                {
                    right = middle-1;
                }
                else
                {
                    left = middle+1;
                }
            }
        }
    }
}