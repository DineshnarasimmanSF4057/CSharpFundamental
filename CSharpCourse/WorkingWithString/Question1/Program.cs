using System.Security.AccessControl;
using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        string input="Syncfusion";
        //old number of characters
        for(int i=0;i<input.Length;i++)
        {
            System.Console.Write(input[i]);
            i++;
        }
        //replace n with N
        input=input.Replace('n','N');
        System.Console.WriteLine();
        for(int i=0;i<input.Length;i++)
        {
            System.Console.Write(input[i]);  
        }
        //reverse the string
        
        System.Console.WriteLine();
        for(int i=input.Length-1;i>=0;i--)
        {
            System.Console.Write(input[i]);
            
        }

        //Length
        int j=0;
        foreach(char a in input)
        {
            j++;
        }
        System.Console.WriteLine($"Length of the string is {j} ");

        //concatenation of two strings
        System.Console.WriteLine("Enter a string");
        string one=Console.ReadLine();
        
        System.Console.WriteLine("Enter a string");
        string two=Console.ReadLine();
        
        string three="";
        for(int i=0,k=two.Length-1;i<4||k>two.Length-3-1;i++)
        {
            if(i<4)
            {
                three+=one[i];
            }
            if(i>=3)
            {
                three+=two[k];
                k--;
            }

            
        }
        System.Console.WriteLine();
        for(int i=0;i<three.Length;i++)

        {
            System.Console.Write(three[i]);
        }
    }
}