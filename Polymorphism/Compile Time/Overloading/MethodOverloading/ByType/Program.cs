using System;
namespace ByType;
class Program{
    public static void Main(string[] args)
    {
        //Add method to add integer
        int tesult = Add(1,5);
        string result1 = Add("kkk","kkkk");
    }

    public static int Add(int a, int b){
        return a+b;
    }

    public static string Add(string a, string b){
        return a+b;
    }
}