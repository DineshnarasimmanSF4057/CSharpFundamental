using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        //Find Largest Number among three
        System.Console.WriteLine("Enter  number1");
        int number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter number2");
        int number2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter number3");
        int number3=int.Parse(Console.ReadLine());

        if(number1>=number2 && number1>=number3)
        {
            System.Console.WriteLine($"{number1} is greatest among three");
        }
        else if(number2>=number1 && number2>= number3)
        {
            System.Console.WriteLine($"{number2} is greatest among three");
        }
        else
        {
            System.Console.WriteLine($"{number3} is greatest among three");
        }

        int[] a=new int[5]{1,2,3,4,2};
        System.Console.WriteLine(a);
    }
}