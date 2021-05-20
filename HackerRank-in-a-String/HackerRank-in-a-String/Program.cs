using System;

namespace HackerRank_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                string result = hackerrankInString(s);

                Console.WriteLine(result);
            }
            
        }
        public static string hackerrankInString(string s)
        {
            int index = 0, h = 1, a=2, c=3, k=4 , e=0, r=0,   
        }
    }
}
