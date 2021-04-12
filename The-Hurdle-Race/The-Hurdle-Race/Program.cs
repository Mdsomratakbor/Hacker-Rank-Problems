using System;
using System.Linq;

namespace The_Hurdle_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp))
            ;
            int result = hurdleRace(k, height);
            Console.WriteLine(result);
        }
        // Complete the hurdleRace function below.
        static int hurdleRace(int k, int[] height)
        {
            int max = height.Max();
            int result = 0;
            if (k > max)
                return result;
            else
                return max - k;

        }
    }
}
