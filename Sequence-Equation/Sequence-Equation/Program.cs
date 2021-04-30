using System;
using System.Collections.Generic;
using System.Linq;

namespace Sequence_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> p = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pTemp => Convert.ToInt32(pTemp)).ToList();

            List<int> result = permutationEquation(p);
            result.ForEach(x => Console.WriteLine(x));
        }
        public static List<int> permutationEquation(List<int> p)
        {
            List<int> output = new List<int>();
            for (int i = 1; i <= p.Count; i++)
                output.Add(p.IndexOf(p.IndexOf(i)+1) + 1);
            return output;
        }

    }
}
