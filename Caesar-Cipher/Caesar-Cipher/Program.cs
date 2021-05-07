using System;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string s = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            string result = caesarCipher(s, k);
            Console.WriteLine(result);
        }
        public static string caesarCipher(string s, int k)
        {
            string output = string.Empty;
            string orginalAlphabet = "abcdefghijklmnopqrstuvwxyz";
            string substring = orginalAlphabet.Substring(0, k);
            string roatedString = orginalAlphabet.Remove(0, k);
            string roatedAlphabet = roatedString + substring;
            for (int j = 0; j < s.Length; j++)
            {
                if (Char.IsLetter(s[j]) == false)
                {
                    output = output + s[j];           
                }
                else
                {
                    for (int i = 0; i < orginalAlphabet.Length; i++)
                    {
                        if (Char.IsUpper(s[j]))
                        {
                            if (orginalAlphabet[i].ToString() == s[j].ToString().ToLower())
                            {
                                string upperCase = roatedAlphabet[i].ToString().ToUpper();
                                output = output + upperCase;
                                break;
                            }
                        }
                        if (orginalAlphabet[i] == s[j])
                        {
                           
                            output = output + roatedAlphabet[i];
                            break;
                        }
                    }
                }
              
            }
            return output;
        }

    }
}
