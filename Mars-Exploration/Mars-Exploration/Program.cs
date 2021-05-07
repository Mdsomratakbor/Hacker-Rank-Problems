using System;

namespace Mars_Exploration
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();

            int result = marsExploration(s);
            Console.WriteLine(result);
        }
        public static int marsExploration(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i += 3)
            {
                if (s[i] != 'S')
                    count++;
                if (s[i + 1] != 'O')
                    count++;
                if (s[i + 2] != 'S')
                    count++;
            }
            return count;
        }

    }
}
