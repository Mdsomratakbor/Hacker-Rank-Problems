using System;
using System.Collections.Generic;
using System.Linq;

namespace Picking_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = pickingNumbers(a);
            Console.WriteLine(result);
        }
        public static int pickingNumbers(List<int> a)
        {
            int[] frequency = new int[101];
            foreach (var index in a)
            {
                frequency[index]++;
            }
            int result = 0;
            for (int i = 1; i < 100; i++)
            {
                result = Math.Max(result, frequency[i]+frequency[i-1]);
            }
            return result;
        }
    }
}
