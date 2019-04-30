using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DFA_VarC
{
    class Program
    {
        static void Main(string[] args)
        {
           string text = System.IO.File.ReadAllText(@"C:\Users\tayab\Documents\SP14BCS113.txt");
            string[] keys = { "myproc", "int", "float", "if", "string", "double", "begin", "end", "for", "main", "else", "then", "print" };
            Console.Write("The Generic Symbol Table for DTypes is:\n\n\n");
            int index1 = 1;
            char[] whitespace = new char[] { ' ', '\t' };
            string[] words = text.Split(whitespace);
            string[,] ST_Array = new string[words.Length, 2];
            ST_Array[0, 0] = "Symb";
            ST_Array[0, 1] = "Dtype";

            Regex reg = new Regex("^[a-zA-Z_$][a-zA-Z_$0-9]*$");
            int index2 = 1;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < keys.Length; j++)
                {
                   if (words[i] == keys[j])
                     {
                        if (words[i] == keys[0] || words[i] == keys[1] || words[i] == keys[2] || words[i] == keys[4] || words[i] == keys[5])
                        {
                            ST_Array[index1, 1] = words[i];
                            words[i] = " ";
                            index1++;

                        }
                        else
                        {
                            words[i] = "";
                        }
                    }
                }

                Boolean Is_Symbol = reg.IsMatch(words[i]);

                if (Is_Symbol == true)
                {
                    bool check = false;
                    for (int k = 0; k < words.Length; k++)
                    {
                        if (ST_Array[k, 0] == words[i])
                        {
                            check = true;
                        }
                    }
                    if (!check)
                    {
                        ST_Array[index2, 0] = words[i];
                        index2++;
                    }
                }
            }
            Console.Write("\t1\t2\n\n");
            for (int k = 0; k < index1; k++)
            {
                Console.Write("{0}.\t", k + 1);
                for (int l = 0; l < 2; l++)
                {
                    Console.Write("{0}\t", ST_Array[k, l]);
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
