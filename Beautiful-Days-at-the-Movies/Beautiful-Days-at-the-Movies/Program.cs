using System;

namespace Beautiful_Days_at_the_Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ijk = Console.ReadLine().Split(' ');

            int i = Convert.ToInt32(ijk[0]);

            int j = Convert.ToInt32(ijk[1]);

            int k = Convert.ToInt32(ijk[2]);

            int result = beautifulDays(i, j, k);
            Console.WriteLine(result);
        }
        static int beautifulDays(int startDate, int endDate, int k)
        {
            int countBeautifulDays = 0;

            for(int i = startDate; i<=endDate; i++)
            {
                int reverse = 0, beautifulDay = 0, day = i;
                
                while (day != 0)
                {
                    reverse = reverse * 10 + day % 10;
                    day /= 10;
                }
                beautifulDay = Math.Abs(i-reverse);
                if (beautifulDay % k == 0)
                    countBeautifulDays++;
                
            }
            return countBeautifulDays;
        }
    }
}
