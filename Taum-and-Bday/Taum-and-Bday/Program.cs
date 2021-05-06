using System;
using System.Collections.Generic;

namespace Taum_and_Bday
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());
            List<long> output = new List<long>();
            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int b = Convert.ToInt32(firstMultipleInput[0]);

                int w = Convert.ToInt32(firstMultipleInput[1]);

                string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int bc = Convert.ToInt32(secondMultipleInput[0]);

                int wc = Convert.ToInt32(secondMultipleInput[1]);

                int z = Convert.ToInt32(secondMultipleInput[2]);

                long result = taumBday(b, w, bc, wc, z);
                output.Add(result);
            }
            output.ForEach(z => Console.WriteLine(z));
        }

        public static long taumBday(long b, long w, long bc, long wc, long z)
        {
            long output = 0;
                    
             if (bc+z < wc)
                output = b * bc + w * (z + bc);
            else if (wc+z<bc)
                output =  w * wc + b * (z + wc);
            else
                output = b * bc + w * wc;
            return output;
        }
    }
}
