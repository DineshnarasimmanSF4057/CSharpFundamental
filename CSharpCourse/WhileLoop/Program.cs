using System;
namespace WhileLoop;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("1.Chennai\n2.Delhi\n3.Mumbai\n4.Kolkata");
        System.Console.WriteLine();
        System.Console.WriteLine("Enter your choice");
        int answer = int.Parse(Console.ReadLine());
        
        string choice="yes";
        while (answer != 3&& choice=="yes")
        {
            System.Console.WriteLine("Incorrect");
            System.Console.WriteLine("Do you want to continue(yes/no)");
            choice = Console.ReadLine().ToLower();
            if (choice == "yes")
            {
                System.Console.WriteLine("Enter your choice");
                answer = int.Parse(Console.ReadLine());
            }
        }
        if(answer==3)
        {
            System.Console.WriteLine("Correct");
        }
    }
}