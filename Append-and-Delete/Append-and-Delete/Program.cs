using System;

namespace Append_and_Delete
{
    class Program
    {
        // Complete the appendAndDelete function below.
        static string appendAndDelete(string s, string t, int k)
        {
            int count=0, i;
            if ((s.Length + t.Length) < k)
                return "Yes";
            for(i=0; i<Math.Min(s.Length, t.Length); i++)
            {
                if (s[i] == t[i])
                    count++;
                else
                    break;
            }
             if ((k-s.Length-t.Length+2* count)%2==0) // Case 2
                return "Yes";
            return "No";
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string t = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine());

            string result = appendAndDelete(s, t, k);
            Console.WriteLine(result);
        }
    }
}
