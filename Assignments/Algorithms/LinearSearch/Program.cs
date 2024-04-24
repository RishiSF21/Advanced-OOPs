using System;
namespace LinearSearch;

class Program
{
    public static void Main(string[] args)
    {
        string numbers = "45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77";
        string[] stringArray = numbers.Split(",");
        int[] numberArray = new int[stringArray.Length];
        int key = 66;

        for(int i=0; i<stringArray.Length; i++)
        {
            numberArray[i] = int.Parse(stringArray[i]);
        }

        bool isFound = true;
        for(int i=0; i<numberArray.Length; i++)
        {
            if(numberArray[i]==key)
            {
                isFound = false;
                Console.WriteLine($"Element {key} was found in the index position -> {i}");
            }
        }
        if(isFound)
        {
            Console.WriteLine($"Element not found");
        }
        
        StringSearch.SearchString("SF3067");
        SearchChar.SearchCharacter("m");
        DoubleSearch.SearchDouble();
    }

    
}