using System;
using System.Collections.Generic;

namespace Find_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            List<int> digits = new List<int>();
            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = findDigits(n);
                digits.Add(result);
            }
            digits.ForEach(x => Console.WriteLine(x));

        }
        public static int findDigits(int n)
        {
            int count = 0, value = n ;
    
            while (n > 0)
            {
                var digit = n % 10;
                n /= 10;
                if (digit > 0)
                {
                    if (value % digit == 0)
                        count++;
                }
            }
          
            return count;
        }
    }
       
    }
