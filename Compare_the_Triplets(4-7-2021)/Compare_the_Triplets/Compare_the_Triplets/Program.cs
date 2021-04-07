using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Compare_the_Triplets
{
    class Program
    {
        static int[] CompareTriplets(int[] aliceArray, int[] bobArray)
        {
            int aliceOutput = 0, bobOutput = 0;

            int length = aliceArray.Length;
            for (int i = 0; i < length; i++)
            {
                if (aliceArray[i] > bobArray[i])
                    aliceOutput += 1;
                else if (aliceArray[i] < bobArray[i])
                    bobOutput += 1;
                else
                    continue;

            }
            int[] ouptput = { aliceOutput, bobOutput };

            return ouptput;
        }
        static void Main(string[] args)
        {

            int[] aliceInput = new int[3];
            int[] bobInput = new int[3];
            int[] output = new int[2];

            string[] input = Console.ReadLine().Split(' ');
            for (int j = 0; j < input.Length; j++)
            {
                aliceInput[j] = Convert.ToInt32(input[j]);
            }
            input = Console.ReadLine().Split(' ');
            for (int j = 0; j < input.Length; j++)
            {
                bobInput[j] = Convert.ToInt32(input[j]);
            }

            int[] result = CompareTriplets(aliceInput, bobInput);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
