using System;
using System.Collections.Generic;

namespace Sales_by_Match
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
             sockMerchant(n, ar);

        }
        static void sockMerchant(int n, int[] ar)
        {
            int pairCount = 0;
            List<int> newArray = new List<int>();
            for(int i=0; i<ar.Length; i++)
            {
                if (!newArray.Contains(ar[i]))
                {
                    newArray.Add(ar[i]);
                }
                else
                {
                    pairCount++;
                    newArray.Remove(ar[i]);
                }
            }
            Console.WriteLine(pairCount);
             

        }
    }
}
