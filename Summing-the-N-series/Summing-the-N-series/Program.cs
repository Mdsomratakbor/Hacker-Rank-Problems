using System;
using System.Collections.Generic;

namespace Summing_the_N_series
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());
            List<long> results = new List<long>();
            for (int tItr = 0; tItr < t; tItr++)
            {
                long n = Convert.ToInt64(Console.ReadLine().Trim());

                results.Add(summingSeries(n));

             
            }
           results.ForEach(x => Console.WriteLine(x));

        }
        public static long summingSeries(long n)
        {
            long output = 0;
            //for(int i=1; i<=n; i++)
            //{
            //    int f1 = (i * i);
            //    int f2 = (i - 1);
            //    output += f1 - f2 * f2;
            //}
            long m = 1000000000 + 7;
            output = ((n % m) * (n % m)) % m;
            return output;

        }

    }
}
