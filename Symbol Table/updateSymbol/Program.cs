using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace updateSymbol
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] SymTable = new string[5, 2];
            int row_count = 1;
            SymTable[0, 0] = "Name";
            SymTable[0, 1] = "Type";
            string code = "def proc myproc (int A, float B) { int D,E; D=0; E= A/ round(B); if (E > 5) { print D } }";
            string[] input = Regex.Split(code, @" ");
            for (int i = 0; i < input.Length; i++)
            {

                if (input[i].Equals("("))
                {
                    SymTable[row_count, 0] = input[i - 1];
                    SymTable[row_count, 1] = "function";
                    row_count++;
                }
                else if (input[i].Equals("int") && input[i + 2] != "(")
                {
                    for (int row = 0; row < 5; row++)
                        for (int column = 0; column < 2; column++)
                        {
                            if (input[i + 1].Equals(SymTable[row, column]))
                                break;
                        }
                    SymTable[row_count, 0] = input[i + 1];
                    SymTable[row_count, 1] = input[i];
                    row_count++;
                }
            }
            for (int ii = 0; ii < 5; ii++)
            {
                Console.WriteLine(" ");
                for (int jj = 0; jj < 2; jj++)
                {
                    Console.Write(SymTable[ii, jj] + " ");

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
