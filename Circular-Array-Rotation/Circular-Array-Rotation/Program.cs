using System;
using System.Collections;
using System.Collections.Generic;

namespace Circular_Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nkq = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nkq[0]);

            int k = Convert.ToInt32(nkq[1]);

            int q = Convert.ToInt32(nkq[2]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;

            int[] queries = new int[q];

            for (int i = 0; i < q; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine());
                queries[i] = queriesItem;
            }

             circularArrayRotation(a, k, queries);
           
        }
        static void circularArrayRotation(int[] a, int k, int[] queries)
        {
            k = k % a.Length;
            int SIZE = a.Length - 1;
            reverse(a,0, SIZE);
            reverse(a, 0, k-1);
            reverse(a, k, SIZE);
            var output =new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
                Console.WriteLine(a[queries[i]]);
             
        }
        /// HACK : This code is exicution time out
        //static int[] circularArrayRotation(int[] a, int k, int[] queries)
        //{
        //    k = k % a.Length;

        //    for (int i=1; i<=k; i++)
        //    {
        //        int j, last;


        //        /* Store last element of array */
        //        last = a[a.Length - 1];

        //        for (j = a.Length - 1; j > 0; j--)
        //        {
        //            /* Move each array element to its right */
        //            a[j] = a[j - 1];
        //        }

        //        /* Copy last element of array to first */
        //        a[0] = last;
        //    }
        //    //int[] array = new int[queries.Length];
        //    //for (int i=0; i<queries.Length; i++)
        //    //{
        //    //    array[i] =(a[queries[i]]);
        //    //}

        //    return a;

        //}
        static void reverse(int[] a, int m, int n)
        {
            while (m < n)
            {
                int temp = a[m];
                a[m] = a[n];
                a[n] = temp;
                ++m;
                --n;
            }
        }
 
    }
}
