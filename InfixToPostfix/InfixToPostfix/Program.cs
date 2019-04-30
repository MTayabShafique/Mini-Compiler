using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfixToPostfix
{
    class Program
    {
        static void Main(string[] args)
        {
            string infix = "2 * 3 / ( 2 - 1 ) + 5 * 3 ";
            string[] st = infix.Split(' ');   

            Stack<string> s = new Stack<string>();
            List<string> output = new List<string>();
            int n;
            foreach (string c in st)
            {
                if (int.TryParse(c.ToString(), out n))
                {
                    output.Add(c);
                }
                if (c == "(")
                {
                    s.Push(c);
                }
                if (c == ")")
                {
                    while (s.Count != 0 && s.Peek() != "(")
                    {
                        output.Add(s.Pop());
                    }
                    s.Pop();
                }
                if (Operator(c) == true)
                {
                    while (s.Count != 0 && presedence(s.Peek()) >= presedence(c))
                    {
                        output.Add(s.Pop());
                    }
                    s.Push(c);
                }
            }
            while (s.Count != 0)
            {
                output.Add(s.Pop());
            }
            for (int i = 0; i < output.Count; i++)
            {
                Console.Write("{0}", output[i]);
            }

            Console.ReadLine();
        }
        static int presedence(string c)
        {
           if (c == "*" || c == "/")
            {
                return 2;
            }
            else if (c == "+" || c == "-")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static bool Operator(string c)
        {
            if (c == "+" || c == "-" || c == "*" || c == "/")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
