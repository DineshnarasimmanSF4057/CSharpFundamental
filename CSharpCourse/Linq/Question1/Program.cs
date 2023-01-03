using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        string[] city={"Agra","Mumbai","Delhi","Abudabi","Madurai","Amsterdam","Nairobi"};
        System.Console.WriteLine("Enter first character");
        char userChoice=char.Parse(Console.ReadLine().ToUpper());
        System.Console.WriteLine("Enter last character");
        char lastChar=char.Parse(Console.ReadLine().ToLower());
        IEnumerable<string> query= (from cities in city where cities[0]==userChoice &&cities[cities.Length-1]==lastChar select cities);

        foreach(string cityName in query)
        {
            System.Console.WriteLine(cityName);
        }
    }
}