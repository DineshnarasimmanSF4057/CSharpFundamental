using System;
namespace Operations;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number 1");
        int number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter number 2");
        int number2=int.Parse(Console.ReadLine());

        //Addition
        int result=number1+number2;
        //subtraction
        int subtraction=number1-number2;
        //Multiplication
        int multiplication=number1*number2;
        //division
        int division=number1/number2;
        //Modulus
        int modulus=number1%number2;

        System.Console.WriteLine($"The sum of {number1} and {number2} is {result} ");
        System.Console.WriteLine($"The difference of {number1} and {number2} is {subtraction} ");
        System.Console.WriteLine($"The multiplication of {number1} and {number2} is {multiplication} ");
        System.Console.WriteLine($"The division of {number1} and {number2} is {division} ");
        System.Console.WriteLine($"The modulus of {number1} and {number2} is {modulus} ");
    }
}