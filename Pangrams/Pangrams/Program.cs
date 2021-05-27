using System;
using System.Collections.Generic;

namespace Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = pangrams(s);
            Console.WriteLine(result);
        }
        public static string pangrams(string s)
        {
            int count = 1;
            s = s.Replace(" ", string.Empty);
            s = s.ToLower();
            var unique = new HashSet<char>(s);
            if (unique.Count >= 26)
            {
                foreach (var value in unique)
                {
                    if (value == 'a' || value == 'b' || value == 'c' || value == 'd' || value == 'e' || value == 'f' || value == 'g' || value == 'h' || value == 'i' || value == 'j' || value == 'k' || value == 'l' || value == 'm' || value == 'n' || value == 'o' || value == 'p' || value == 'q' || value == 'r' || value == 's' || value == 't' || value == 'u' || value == 'v' || value == 'w' || value == 'x' || value == 'y' || value == 'z')
                    {
                        count++;
                        if (count == 26)
                        {
                            return "pangram";
                        }
                    }
                }
            }

            return "not pangram";

        }
    }
}
