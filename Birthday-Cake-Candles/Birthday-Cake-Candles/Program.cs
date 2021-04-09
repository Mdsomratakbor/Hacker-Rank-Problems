using System;
using System.Linq;

namespace Birthday_Cake_Candles
{
    class Program
    {
        static void Main(string[] args)
        {
            int candlesSize = Convert.ToInt32(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            long[] arrayCandles = Array.ConvertAll(inputs, long.Parse);
          Console.Write(MaxNumberPrint(arrayCandles));
        }
        static long MaxNumberPrint(long[] arr)
        {
            long maxNumber = arr.Max();
            int output = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if(maxNumber== arr[i])
                {
                    output++;
                }
            }
            return output;
        }
    }
}
