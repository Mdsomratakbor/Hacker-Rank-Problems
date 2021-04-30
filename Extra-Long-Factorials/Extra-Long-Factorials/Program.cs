using System;
using System.Numerics;

namespace Extra_Long_Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            extraLongFactorials(n);
        }
        static void extraLongFactorials(int n)
        {
            var  fact = BigInteger.One;
            for (int i = n; i > 0; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
