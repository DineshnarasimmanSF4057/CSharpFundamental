using System;
namespace Switch;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a number");
        int number1=int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter a number");
        int number2=int.Parse(Console.ReadLine());

        System.Console.WriteLine("Press 1 to add two numbers");
        System.Console.WriteLine("Press 2 to subtract two numbers");
        System.Console.WriteLine("Press 3 to Multiply two numbers");
        System.Console.WriteLine("Press 4 to Divide two numbers");

        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                System.Console.WriteLine($"The sum of two number is {number1+number2} ");
                break;
            }
            case 2:
            {
                System.Console.WriteLine($"The difference of two number is {number1-number2} ");
                break;
            }
            case 3:
            {
                System.Console.WriteLine($"The multiply of two number is {number1*number2} ");
                break;
            }
            case 4:
            {
                System.Console.WriteLine($"The quotient of two number is {number1/number2} ");
                break;
            }default:
            {
                System.Console.WriteLine("Enter the correct value");
                break;
            }
            
        }
    }
}