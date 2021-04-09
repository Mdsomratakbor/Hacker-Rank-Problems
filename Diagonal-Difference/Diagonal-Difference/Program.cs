using System;
using System.Collections.Generic;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArray = Convert.ToInt32(Console.ReadLine());
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < numberOfArray; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }
            Console.WriteLine(diagonalDifference(arr));
        }
        public static int diagonalDifference(List<List<int>> arr)
        {
            int[] result = { 0, 0 };
            for(int i=0; i<arr.Count(); i++)
            {
                int a = arr[i][0 + i];
                int b = arr[i][arr.Count() - 1 - i];
                result[0] =  result[0] + a;
                result[1] = result[1] + b;
            }
            return Math.Abs(result[0] - result[1]);
        }
    }
}
