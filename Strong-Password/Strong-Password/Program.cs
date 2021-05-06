using System;
using System.Text.RegularExpressions;

namespace Strong_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string password = Console.ReadLine();

            int answer = minimumNumber(n, password);
            Console.WriteLine(answer);
        }
        public static int minimumNumber(int n, string password)
        {
            int  countDigit = 1, countUpperCase = 1, countLowerCase = 1, countSpecialcha = 1, lessLength = 0;
            for (int i = 0; i < password.Length; i++)
            {

                if (Char.IsDigit(password[i]))
                    countDigit--;
                else if (char.IsUpper(password[i]))
                    countUpperCase--;
                else if (char.IsLower(password[i]))
                    countLowerCase--;
                else if (IsMatch(password[i]))
                    countSpecialcha--;
            }
            if (n < 6)
            {
                int q = 6 - n;

                if (countDigit > 0)
                    lessLength += countDigit;
                if (countUpperCase > 0)
                    lessLength += countUpperCase;
                if (countLowerCase > 0)
                    lessLength += countLowerCase;
                if (countSpecialcha > 0)
                    lessLength += countSpecialcha;
                if (lessLength < q)
                    lessLength = q;

            }
                
         
            if (n >= 6)
            {
                 if (countDigit > 0)
                lessLength += countDigit;
                 if (countUpperCase > 0)
                lessLength += countUpperCase;
                 if (countLowerCase > 0)
                lessLength += countLowerCase;
                 if (countSpecialcha > 0)
                lessLength += countSpecialcha;
            }
          
            
            return lessLength;
        }
        static bool IsMatch(char input)
        {
            bool output = false;
            string specialCharater = "!@#$%^&*()-+";
            for (int i = 0; i < specialCharater.Length; i++)
            {
                if (input == specialCharater[i])
                {
                    output = true;
                    break;
                }
                    
            }
                
                 return output;
        }
    }
}
