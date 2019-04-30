using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfixtoPostfixEvaluate
{
    class Program
    {
        static bool convert(ref string infix, out string postfix)
        {
            int priority = 0;

            postfix = "";

            Stack<Char> s1 = new Stack<char>();

            for (int i = 0; i < infix.Length; i++)
            {

                char ch = infix[i];

                if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '(')
                {

                    if (s1.Count <= 0)

                        s1.Push(ch);

                    else
                    {

                        if (s1.Peek() == '*' || s1.Peek() == '/' || s1.Peek() == '(')

                            priority = 1;

                        else

                            priority = 0;

                        if (priority == 1)
                        {
                            if (ch == '+' || ch == '-')
                            {
                                postfix += s1.Pop();
                                i--;
                            }

                            else
                            {
                                postfix += s1.Pop();
                                i--;
                            }
                        }

                        else
                        {
                            if (ch == '+' || ch == '-')
                            {
                                postfix += s1.Pop();
                                s1.Push(ch);
                            }
                            else
                                s1.Push(ch);
                        }
                    }
                }
                else
                {
                    postfix += ch;
                }
            }

            int len = s1.Count;
            for (int j = 0; j < len; j++)
            postfix += s1.Pop();
            return true;
        }

        static void Main(string[] args)
        {
            string infix = "";

            string postfix = "";

            if (args.Length == 1)
            {
                infix = args[0];
                convert(ref infix, out postfix);
                Stack<int> num = new Stack<int>();
                System.Console.WriteLine("InFix  :\t" + infix);
                System.Console.WriteLine("PostFix:\t" + postfix);
            }
            else
            {
                System.Console.WriteLine("Enter An Expression");
                infix = Console.ReadLine();

                convert(ref infix, out postfix);

                System.Console.WriteLine("InFix   :\t" + infix);

                System.Console.WriteLine("PostFix :\t" + postfix);
                Stack<int> num = new Stack<int>();
                int temp;
                for (int k = 0; k < postfix.Length; k++)
                {
                    char ch = postfix[k];
                    if (ch != '+' || ch != '-' || ch != '*' || ch != '/' || ch != '^' || ch != '%')
                    {
                        Int32.TryParse(ch.ToString(), out temp);
                        num.Push(temp);
                    }
                    int a, b;

                    if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '^' || ch == '%')
                    {
                        if (num.Peek() == 0)
                        {
                            num.Pop();
                        }
                        a = num.Pop();
                        b = num.Pop();
                        //System.Console.WriteLine(a);
                        //System.Console.WriteLine(b);
                        if (ch == '+')
                        {
                            a += b;
                            System.Console.WriteLine(a);
                            num.Push(a);
                        }
                        if (ch == '*')
                        {
                            a *= b;
                            System.Console.WriteLine(a);
                            num.Push(a);
                        }
                        if (ch == '-')
                        {
                            b -= a;
                            System.Console.WriteLine(b);
                            num.Push(b);
                        }
                        if (ch == '/')
                        {
                            b /= a;
                            System.Console.WriteLine(b);
                            num.Push(b);
                        }
                        if (ch == '^')
                        {
                            a ^= b;
                            System.Console.WriteLine(a);
                            num.Push(a);
                        }
                        if (ch == '%')
                        {
                            b %= a;
                            System.Console.WriteLine(b);
                            num.Push(b);
                        }

                    }
                }

                System.Console.WriteLine();
                Console.ReadLine();

            }

        }

    }

}