using System;

namespace Drawing_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int p = Convert.ToInt32(Console.ReadLine());
            maxTurns(n, p);
        }
        static void maxTurns(int n, int p)
        {
            int fromBack;
            int fromFront = (int)Math.Ceiling(((float)(p - 1)) / 2);

            if (n % 2 == 1)
            {
                fromBack = (n - p) / 2;
            }
            else
            {
                fromBack = (int)Math.Ceiling(((float)(n - p)) / 2);
            }
            if (fromFront <= fromBack) Console.WriteLine(fromFront);
            else Console.WriteLine(fromBack);
        }
    }
}
