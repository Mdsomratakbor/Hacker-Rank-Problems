using System;

namespace Plus_Minus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
           var output = plusMinus(arr);
            Console.WriteLine(output[0].ToString("f6"));
            Console.WriteLine(output[1].ToString("f6"));
            Console.WriteLine(output[2].ToString("f6"));
        }
        // Complete the plusMinus function below.
        static double[] plusMinus(int[] arr)
        {
            double[] result = new double[] { 0.000000F, 0.000000F, 0.000000F };
            int totalPlus = 0, totalMinus = 0, totalZero = 0, totalLength = arr.Length;
            for (int i = 0; i < totalLength; i++)
            {
                if (arr[i] > 0)

                    totalPlus++;

                else if (arr[i] < 0)

                    totalMinus++;

                else
                    totalZero++;
            }
            result[0] = (double)totalPlus / totalLength;
            result[1] = (double)totalMinus / totalLength;
            result[2] = (double)totalZero / totalLength;
            return result;
        }
    }
}
