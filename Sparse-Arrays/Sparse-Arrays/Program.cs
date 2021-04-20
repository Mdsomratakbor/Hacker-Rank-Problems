using System;
using System.Collections.Generic;

namespace Sparse_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int stringsCount = Convert.ToInt32(Console.ReadLine());

            string[] strings = new string[stringsCount];

            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings[i] = stringsItem;
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine());

            string[] queries = new string[queriesCount];

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries[i] = queriesItem;
            }

            var result = matchingStrings(strings, queries);
            foreach(var data in result)
            Console.WriteLine(data);
        }
        static List<int> matchingStrings(string[] strings, string[] queries)
        {
            
            List<int> output = new List<int>();
            for(int i=0; i < queries.Length; i++)
            {
                int count = 0;
                for(int j=0; j<strings.Length; j++)
                {
                    if (queries[i] == strings[j])
                        count++;
                    
                }
                output.Add(count);
            }
            return output;
        }
    }
}
