using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Infix_Postfix
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("Enter Password !");
            string password = Console.ReadLine();
            String[] word= password.Split(' ');
            //string pattern = ();
            Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{6,12}$");
            for (int i = 0; i < word.Length; i++)
            {
                Match match = regex.Match(word[i]);
                if (match.Success)
                {
                    Console.WriteLine(word[i] + " Password is correct ! ");

                }
                else
                {
                    Console.WriteLine(word[i] + " Password is  incorrect! ");

                }
            }
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}




























