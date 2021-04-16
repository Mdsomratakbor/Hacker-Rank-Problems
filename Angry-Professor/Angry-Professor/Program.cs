using System;
using System.Collections.Generic;

namespace Angry_Professor
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            List<string> outputList = new List<string>();
            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
                ;
                outputList.Add(angryProfessor(k, a));
              
            }
            foreach(var data in outputList)
                Console.WriteLine(data);
        }
        static string angryProfessor(int k, int[] a)
        {
            string output = string.Empty;
            int presentStudents = 0;
            for(int i=0;i<a.Length; i++)
            {
                if (a[i] <= 0)
                    presentStudents++;
            }
            if (presentStudents < k)
                output = "YES";
            else
                output = "NO";
            return output;
        }
    }
}
