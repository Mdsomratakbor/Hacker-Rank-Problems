using System;

namespace Divisible_Sum_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = divisibleSumPairs(n, k, ar);
            Console.WriteLine(result);
        }
        // Complete the divisibleSumPairs function below.
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int count = 0;
            for(int i=0; i<ar.Length; i++)
            {
                for(int j=i+1; j<ar.Length; j++)
                {
                    var value = ar[i] + ar[j];
                    if (value  % k == 0)
                        count++;
                }
            }
            return count;
        }

    }
}
