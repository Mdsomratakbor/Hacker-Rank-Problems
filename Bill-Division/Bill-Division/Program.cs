using System;
using System.Collections.Generic;
using System.Linq;

namespace Bill_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            long[] bill = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp))
            ;

            int b = Convert.ToInt32(Console.ReadLine().Trim());
            bonAppetit(bill, k, b);
        }
        // Complete the bonAppetit function below.
        static void bonAppetit(long[] bill, int k, int b)
        {
            long totalAmount = 0;

            for (int i = 0; i < bill.Length; i++)
            {
                totalAmount += bill[i];
            }

            totalAmount = totalAmount - bill[k];
                totalAmount = totalAmount / 2;
            
            
            if (totalAmount == b)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(Math.Abs(totalAmount - b));

        }
    }
}
