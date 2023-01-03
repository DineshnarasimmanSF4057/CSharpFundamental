using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        string inputs="Chennai,Trichy,Mumbai";
        string[] result=inputs.Split(",");
        for(int i=0;i<result.Length;i++)
        {
            System.Console.WriteLine(result[i]);
        }
    }
}