using System;
using System.Text.RegularExpressions;

namespace DFA_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] state = new int[3];
            for (int i = 1; i < 3; i++)
            {
                state[i] = 0;
            }
            state[0] = 1;
            Console.WriteLine("Enter variable name of C language :");
            String s = Console.ReadLine();
            Console.WriteLine("Variable name is : " + s);
            Regex Rgx = new Regex(@"\b(int|double|char|struct|if|register|goto|while|do|for|float|printf)\b");
            Match match1 = Rgx.Match(s);
            if (match1.Success)
            {
                Console.WriteLine("Invalid variable name\n keyword Detected  " + s);
                state[1] = 1;
            }
            else
            {
                int leng = s.Length;
                if (leng > 31)
                {
                    Console.WriteLine("variable length exceeded");
                    state[1] = 1;
                }

                else
                {
                    Regex rgx = new Regex(@"^[A-Za-z|_][A-Za-z|_|0-9]*$");
                    Match match2 = rgx.Match(s);
                    if (match2.Success)
                    {
                        state[2] = 1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid variable" + s);
                        state[1] = 1;
                    }
                }
            }
            if (state[0] == 1 && state[1] == 1)
            {
                Console.WriteLine("DFA rejected the String\nIt is in a Trap State");
            }
            if (state[0] == 1 && state[2] == 1)
            {
                Console.WriteLine("DFA accpepts the String\nIt is in Accepting State");
            }
            Console.ReadLine();

        }

    }
}
