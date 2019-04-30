using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtraWhiteString
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a String");
            String s = System.Console.ReadLine();
            String Pattern = "\\s+";
            String r = " ";
            Regex rgx = new Regex(Pattern);
            String rep = rgx.Replace(s, r);
            Console.WriteLine("Original String {0}", s);
            Console.WriteLine("Replacement String: {0}", rep);
            System.Console.ReadLine();
            
        }

    }
}
