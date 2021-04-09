using System;

namespace Time_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.Write(ToFormat24h(Convert.ToDateTime(input)));
        }
        //public static string ToFormat12h(DateTime dt)
        //{
        //    return dt.ToString("yyyy/MM/dd, hh:mm:ss tt");
        //}

        public static string ToFormat24h(DateTime dt)
        {
            return dt.ToString("HH:mm:ss");
        }
    }
}
