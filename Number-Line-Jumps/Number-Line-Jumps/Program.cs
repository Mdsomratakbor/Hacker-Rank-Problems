using System;

namespace Number_Line_Jumps
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x1V1X2V2 = Console.ReadLine().Split(' ');

            int x1 = Convert.ToInt32(x1V1X2V2[0]);

            int v1 = Convert.ToInt32(x1V1X2V2[1]);

            int x2 = Convert.ToInt32(x1V1X2V2[2]);

            int v2 = Convert.ToInt32(x1V1X2V2[3]);

            string result = kangaroo(x1, v1, x2, v2);
            Console.WriteLine(result);
        }
        // Complete the kangaroo function below.
        static string kangaroo(int x1, int v1, int x2, int v2)
        {

            int vdiff = (v1 - v2);
            if (vdiff <= 0)
                return "NO";

            return (x1 - x2) % vdiff == 0 ? "YES" : "NO";
        }

    }
}
