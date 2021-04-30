using System;
using System.Collections.Generic;

namespace Save_the_Prisoner
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> output = new List<int>();
            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int m = Convert.ToInt32(firstMultipleInput[1]);

                int s = Convert.ToInt32(firstMultipleInput[2]);


                output.Add(NewThePrisoner(n, m, s));
            }
            for(int x =0; x<output.Count; x++)
                Console.WriteLine(output[x]);


        }

        // HACK: THIS METHOD IS CROSS LIMITED TIME
        public static int saveThePrisoner(int n, int m, int s)
        {
            int count = s;
            for (int i=1; i<m; i++)
            {
                if (count > n)
                    count = 1;
                count++;
            }
            return count;
        }
        public static int NewThePrisoner(int n, int m, int s)
        {
            return ((m - 1) + (s - 1)) % n + 1;
        }

    }
}
