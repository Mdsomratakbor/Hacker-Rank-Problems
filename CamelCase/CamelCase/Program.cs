using System;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int result = camelcase(s);
            Console.WriteLine(result);
        }
        public static int camelcase(string s)
        {
            int count = 1;
            for (int i = 0; i < s.Length; i++)
                if (Char.IsUpper(s[i]))
                    count++;
            return count;
        }

    }
}
