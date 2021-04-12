using System;
using System.Collections.Generic;

namespace Minimum_Distances
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int result = minimumDistances(a);
            Console.WriteLine(result);
        }
        // Complete the minimumDistances function below.
        static int minimumDistances(int[] a)
        {
            Dictionary<int, int> dMap = new Dictionary<int, int>();
            int minDistance = 0, prvIndex = 0, currentIndex = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (dMap.ContainsKey(a[i]))
                {
                    currentIndex = i;
                    foreach(var d in dMap)
                    {
                        if (d.Key == a[i])
                        {
                            prvIndex = d.Key;
                        }
                       
                    }
                    minDistance = Math.Min(currentIndex-prvIndex, minDistance);
                }
                else
                {
                    dMap.Add(a[i], i);
                }
               
            }
            return (minDistance<=0?-1: minDistance);

        }

    }
}
