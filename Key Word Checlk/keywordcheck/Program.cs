using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace keywordcheck
{
    class Program
    {
        static void Main(string[] args)
        {

            String var2 = "Diffusion refers to the process by which molecules intermingle as a result of their kinetic energy of random motion. Consider two containers of gas A and B separated by a partition. The molecules of both gases are in constant motion and make numerous collisions with the partition. If the partition is removed as in the lower illustration, the gases will mix because of the random velocities of their molecules. In time a uniform mixture of A and B molecules will be produced in the container. The tendency toward diffusion is very strong even at room temperature because of the high molecular velocities associated with the thermal energy of the particles.";
            Console.WriteLine(var2);
            String[] words = var2.Split(' ');
            String Patern = @"(t|m)\W*(\w+)e\b{4}$";
            Regex rgx2 = new Regex(Patern);
            Console.WriteLine(" ");
            System.Console.WriteLine("< Words Length greater than 4 and Matching words that start with 't' or 'm' and end with 'e' >");
            for (int i = 0; i < words.Length; i++)
            {
                Match match3 = rgx2.Match(words[i]);

                if (match3.Success)
                {
                    
                    System.Console.WriteLine(words[i] + " ");
                }
            }
            System.Console.ReadLine();
        }
    }
}