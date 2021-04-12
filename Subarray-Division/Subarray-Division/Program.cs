using System;
using System.Collections.Generic;
using System.Linq;

namespace Subarray_Division
{
    class Program
    {
        // Complete the birthday function below.
        
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int[] s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToArray();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = birthday(n, s, d, m);
            Console.WriteLine(result);
        }
        static int birthday(int n, int[] s, int d, int m)
        {
            // Complete this function
            int[] sum = new int[105];
            int count = 0;
            sum[0] = 0;
            for (int i = 0; i < n; i++) sum[i + 1] = sum[i] + s[i];
            for (int i = 0; i <= n - m; i++)
            {
                if (sum[i + m] - sum[i] == d)
                {
                    count++;
                }
            }
            return count;

        }
    }
}
