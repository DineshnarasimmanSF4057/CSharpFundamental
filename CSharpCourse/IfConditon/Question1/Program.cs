using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your grade (A,B,C,D)");
        char grade=char.Parse(Console.ReadLine().ToUpper());

        if(grade=='A')
        {
            System.Console.WriteLine($"Grade {grade} denotes 9 points ");
        }
        else if(grade=='B')
        {
            System.Console.WriteLine($"Grade {grade} denotes 8 points");
        }
        else if(grade=='C')
        {
            System.Console.WriteLine($"Grade {grade} denotes 7 points");
        }
        else if(grade=='D')
        {
            System.Console.WriteLine($"Grade {grade} denotes 6 points");
        }
        else
        {
            System.Console.WriteLine("This is not a valid grade");
        }
    }
}