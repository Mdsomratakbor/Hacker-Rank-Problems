using System;

namespace Apple_and_Orange
{
    class Program
    {
        // Complete the countApplesAndOranges function below.
        static void countApplesAndOranges(int houseStart, int houseEnd, int appleTree, int orangeTree, int[] apples, int[] oranges)
        {
            int samApples = 0, samOranges = 0;
            foreach (var apple in apples)
            {
                var fallingApplePosition = appleTree + apple;
                if (fallingApplePosition >= houseStart && fallingApplePosition <= houseEnd)
                {
                    samApples++;
                }
            }
            foreach (var orange in oranges)
            {
                var fallingOrangePosition = orangeTree + orange;
                if (fallingOrangePosition >= houseStart && fallingOrangePosition <= houseEnd)
                {
                    samOranges++;
                }
            }

            Console.WriteLine(samApples);
            Console.WriteLine(samOranges);
        }
        static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
            ;

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
            ;
            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
