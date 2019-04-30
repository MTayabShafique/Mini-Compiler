using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Text.RegularExpressions;

namespace RegularExpOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "Hello  People  Hi";
            String Pattern = "\\s+";
            String r = " ";
            Regex regx = new Regex(Pattern);
            String rep = regx.Replace(s, r);
            Console.WriteLine("<1st Task>");
            Console.WriteLine("Original String is: {0} ", s);
            Console.WriteLine("Replacement String is: {0} ", rep);
            System.Console.WriteLine(" ");

            System.Console.WriteLine("<2nd Task>");
            String var = "4-2+5*8";
            System.Console.WriteLine("Expression is"+ "  "+ var);
            Regex rgx = new Regex(@"[+-/*]");
            for (int i = 0; i < var.Length; i++)
            {
                Match match1 = rgx.Match(var[i].ToString());
                if (match1.Success)
                {
                    System.Console.WriteLine(var[i] + " ");
                }

            }



            System.Console.WriteLine(" ");
            Console.WriteLine("<3rd Task>");
            String var1 = "2<1&&3>0";
            System.Console.WriteLine("Expression is" + "  " + var1);
            String pattern = @"[&&<>|=]";
            Regex rgx1 = new Regex(pattern);
            for (int i = 0; i < var1.Length; i++)
            {
                Match match2 = rgx1.Match(var1[i].ToString());
                

                if (match2.Success)
                {
                    System.Console.WriteLine(var1[i] + " ");
                }
               
            }



            System.Console.WriteLine(" ");
            Console.WriteLine("<Home Task>");
            String var2 = "tayyab_113__t1_123opbg__wecssanvjei____678____edfdffsfkwwefdfs12906__";
            System.Console.WriteLine("Variable name is" + " " + var2);
            String Patern = @"^[a-zA-Z_][a-zA-Z_$0-9]*$";
            Regex rgx2 = new Regex(Patern);
            Match match3 = rgx2.Match(var2.ToString());


                if (match3.Success && var2.Length<50)
                {
                    System.Console.WriteLine(" Variable name is Valid!");
                }
                else
                {
                    System.Console.WriteLine(" Variable name is Invalid!");
                }

            System.Console.ReadLine();
        }
    }
}
   