using System;
namespace ForLoop;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter 10 numbers");
        int sum=0;
        for(int i=0;i<10;i++)
        {
            int number=int.Parse(Console.ReadLine());
            sum+=number;
        }
        System.Console.WriteLine($"Sum of 10 number is {sum}");
        System.Console.WriteLine($"Average of 10 numbers is {(double)sum/10}");
    }
}