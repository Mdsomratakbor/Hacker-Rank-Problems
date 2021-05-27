using System;
using System.Collections.Generic;

namespace Weighted_Uniform_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> queries = new List<int>();

            for (int i = 0; i < queriesCount; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
                queries.Add(queriesItem);
            }

            List<string> result = weightedUniformStrings(s, queries);
        }
        public static List<string> weightedUniformStrings(string s, List<int> queries)
        {

        }
    }
}
