using System;
using System.Collections.Generic;
using System.Linq;

namespace Insert_a_node_at_the_head_of_a_linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = new List<string>();
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                inputs.Add(Console.ReadLine());
            }
            for(int i= inputs.Count-1; i>=0; i--)
            {
                Console.WriteLine(inputs[i]);
            }
        }
    }
}
