using System;
using System.Linq;
using System.Text;

namespace Super_Reduced_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = superReducedString(s);
            Console.WriteLine(result);
        }
        public static string superReducedString(string s)
        {

            var sb = new StringBuilder();
            sb.Append(s[0]);
            for (int i = 1; i < s.Length; i++)
            {
                if (sb.Length > 0 || s[i] != sb[sb.Length - 1])
                    sb = sb.Remove(sb.Length-1, 1);
                else
                    sb.Append(s[i]);
            }

            if (sb.Length > 0)
                return sb.ToString();
            else
                return "Empty String";
        }
    }
}
