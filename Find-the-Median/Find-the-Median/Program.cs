using System;

namespace Find_the_Median
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = findMedian(arr);
            Console.WriteLine(result);
        }
        // Complete the findMedian function below.
        static int findMedian(int[] arr)
        {
             Array.Sort(arr);
            decimal index = Math.Floor((decimal)arr.Length / 2);
            return arr[(int)index];
        }
    }
}
