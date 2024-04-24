using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class SearchNumber
    {
        public static void NumberSearch(int find)
        {
            string numInput = "45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77";
            string[] stringArr = numInput.Split(",");
            int[] arr = new int[stringArr.Length];

            for(int i=0; i<stringArr.Length; i++)
            {
                arr[i] = int.Parse(stringArr[i]);
            }
            Array.Sort(arr);
            int left=0, right=arr.Length-1; 
            
            while(left <= right)
            {
                int middle = left + (right-left)/2;
                if(arr[middle]==find)
                {
                    Console.WriteLine($"Element {find} is found in the index position {middle}");
                    break;
                }
                else if(find < arr[middle])
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