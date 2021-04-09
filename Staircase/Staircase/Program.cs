using System;
using System.Collections.Generic;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

           //var output= staircase(n);
            for (int i = 1; i <= n; i++)
            {
                var spaces = new String(' ', n - i);
                var hashes = new String('#', i);
                Console.WriteLine(spaces + hashes);
            }
            //foreach (var data in output)
            //{
            //    Console.WriteLine(data);
            //}
        }
        //static List<string> staircase(int n)
        //{
        //    List<string> output = new List<string>();
       
        //    for(int i=0; i<= n; i++)
        //    {
        //        string data = string.Empty;
        //        for (int j=0; j<i; j++)
        //        {                   
        //            data = $"{data}#";
        //        }
        //        if (data.Length > 0)
        //        {
        //            output.Add(data);
        //        }
             
        //    }
        //    return output;
        //}
    }
}
