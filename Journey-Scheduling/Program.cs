using System;

namespace Journey_Scheduling
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            int N, M;
            string[] nm = Console.ReadLine().Split(' ');
            N = Convert.ToInt32(nm[0]);
            M = Convert.ToInt32(nm[1]);

            int[,] roades = new int[N - 1, 2];

            for(int roadsRowItr = 0; roadsRowItr < N-1; roadsRowItr++)
            {
                string[] roadRowItems = Console.ReadLine().Split(' ');
                for(int roadsColumnItr = 0; roadsColumnItr < 2; roadsColumnItr++)
                {
                    int roadItem = Convert.ToInt32(roadRowItems[roadsColumnItr]);
                    roades[roadsRowItr, roadsColumnItr] = roadItem;
                }
            }

            int[,] journeys = new int[M, 2];

            for (int journeysRowItr = 0; journeysRowItr < M; journeysRowItr++)
            {
                string[] journeysRowItems = Console.ReadLine().Split(' ');

                for (int journeysColumnItr = 0; journeysColumnItr < 2; journeysColumnItr++)
                {
                    int journeysItem = Convert.ToInt32(journeysRowItems[journeysColumnItr]);
                    journeys[journeysRowItr,journeysColumnItr] = journeysItem;
                }
            }

           

        }
    }
}
