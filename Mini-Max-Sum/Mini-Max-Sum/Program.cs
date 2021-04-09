using System;
using System.Linq;

namespace Mini_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputsArray = Console.ReadLine().Split(' ');
            //HACK :Old Style Code
            //long[] arr = new long[5];

            //for(int i=0; i<inputsArray.Length; i++)
            //{
            //    arr[i] = Convert.ToInt64(inputsArray[i]); 
            //}

            long[] arr = Array.ConvertAll(inputsArray, Int64.Parse);
           var output =  SumMinMaxNumber(arr);
            Console.Write("{0} {1}", output.Item1, output.Item2);

        }
        static Tuple<long, long> SumMinMaxNumber(long[] arr)
        {
            long[] arraySum = new long[5];
            for (int i=0; i<arr.Length; i++)
            {
                long sum = 0;
                for (int j=0;j<arr.Length; j++)
                {
                    sum += arr[j];
                }
                sum -= arr[i];
                arraySum[i] = sum;
            }
            long minNumber = arraySum.Min();
            long maxNumber = arraySum.Max();
            return new Tuple<long, long>(minNumber,maxNumber);
        }
    }
}
