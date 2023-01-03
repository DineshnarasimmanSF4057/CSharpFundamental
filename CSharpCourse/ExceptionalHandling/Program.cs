using System.Security.AccessControl;
using System;
namespace ExceptionalHandling;
class Program{
    public static void Main(string[] args)
    {
        try
        {
            System.Console.WriteLine("Enter first Number");
            int firstNumber=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter second Number");
            int secondNumber=int.Parse(Console.ReadLine());

            if(secondNumber!=0)
            {
                int result=firstNumber/secondNumber;
                System.Console.WriteLine(result);
            }
            else
            {
                System.Console.WriteLine("Infinity");
            }
        }
        catch(DivideByZeroException e)
        {
            System.Console.WriteLine(e.StackTrace);
        }
        catch(FormatException e)
        {
            System.Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
        }
        finally
        {
            System.Console.WriteLine("Closing");
        }
        System.Console.WriteLine("Hello");

    }
}