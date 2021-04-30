using System;

namespace Electronics_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
            ;

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
            ;
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */

            int moneySpent = getMoneySpent(keyboards, drives, b);
            Console.WriteLine(moneySpent > 0 ? moneySpent : -1);
        }
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int maximumNumber = 0;
            for(int i=0;i<drives.Length; i++)
            {
                for(int j=0; j<keyboards.Length; j++)
                {
                    int value = drives[i] + keyboards[j];

                    if (value > maximumNumber && value <= b)
                        maximumNumber = value;
                }
            }
            return maximumNumber;
        }

    }
}
