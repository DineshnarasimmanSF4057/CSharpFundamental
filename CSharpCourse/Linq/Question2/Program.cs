using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        string[] city={"ABU DHABI","AMSTERDAM","ROME","PARIS","CALIFORNIA","LONDON","NEW DELHI","ZURICH","NAIROBI"};
        IEnumerable<string> query=city.OrderBy(c=>c.Length).ThenBy(c=>c);
        foreach(string cities in query)
        {
            System.Console.WriteLine(cities);
        }
    }
}