using System;
namespace WorkingWithDatetime;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine(DateTime.Now.ToString("MMMM"));
        System.Console.WriteLine(DateTime.Now.AddDays(-3).ToString("dd/MM/yyyy"));
        System.Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"));
    }
}