using System;
using System.Collections.Generic;
using System.Linq;

namespace Left_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            int[] arr = Console.ReadLine().TrimEnd().Split(' ').ToArray().Select(arrTemp => Convert.ToInt32(arrTemp)).ToArray();

            //int[] result = rotateLeft(d, arr);
            //for ( int data=0; data<result.Length; data++)
            //    Console.Write($"{result[data]} ");
            for(int i=d; i<arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            for (int i = 0; i < d; i++)
                Console.Write($"{arr[i]} ");
        }
        //public static int[] rotateLeft(int d, int[] a)
        //{
        //    for (int intI = 0; intI < d; intI++)
        //    {
        //        int temp = a[0];

        //        for (int intK = 0; intK < a.Length - 1; intK++)
        //        {
        //            a[a.Length - (a.Length - intK)] = a[a.Length - (a.Length - (intK + 1))];
        //        }

        //        a[a.Length - 1] = temp;
        //    }
        //    return a;
        //}
    
    }
}
