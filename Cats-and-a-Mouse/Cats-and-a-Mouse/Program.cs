using System;
using System.Collections.Generic;

namespace Cats_and_a_Mouse
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            List<string> output = new List<string>();
            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

               output.Add(catAndMouse(x, y, z));
            }
            output.ForEach(x => Console.WriteLine(x));
        }
        // Complete the catAndMouse function below.
        static string catAndMouse(int x, int y, int z)
        {

            string output = string.Empty;
            int catADis = 0, catBDis = 0;
            catADis = Math.Abs(x - z);
            catBDis = Math.Abs(y - z);
            if (catADis > catBDis)
                return "Cat B";
            else if (catBDis > catADis)
                return "Cat A";
            else
                return "Mouse C";

        }
     
    }
}
