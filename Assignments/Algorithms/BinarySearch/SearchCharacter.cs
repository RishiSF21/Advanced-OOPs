using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class SearchCharacter
    {
        public static void CharSearch(string find)
        {
            string numInput = "c,a,f,b,k,h,j,I,i,z,t,m,p,l,d";
            string[] arr = numInput.Split(",");
            // int[] arr = new int[stringArr.Length];

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
                else if()
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