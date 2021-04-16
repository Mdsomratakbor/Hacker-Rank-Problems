using System;
using System.Collections.Generic;

namespace Utopian_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> period = new List<int>();
            int t = Convert.ToInt32(Console.ReadLine());
       

            for (int tItr = 0; tItr < t; tItr++)
            {
                period.Add(Convert.ToInt32(Console.ReadLine())); 
            }
             utopianTree(period);
            



        }
        static void utopianTree(List<int> n)
        {
            List<int> output = new List<int>();
            for (int j = 0; j < n.Count; j++)
            {
                if (n[j] == 0)
                {
                    output.Add(1);
                }
                int treeHeight = 1;
                for (int i = 0; i < n[j]; i++)
                {
                    if (i % 2 == 0)
                    {
                        treeHeight += treeHeight;

                    }

                    else
                    {
                        treeHeight += 1;
                    }

                }
                if (treeHeight > 1)
                {
                    output.Add(treeHeight);
                }

            }
            foreach (var data in output)
            {
                Console.WriteLine(data);
            }

        }
    }
}
