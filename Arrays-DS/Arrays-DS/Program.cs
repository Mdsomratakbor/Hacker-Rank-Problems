using System;

namespace Arrays_DS
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            reverseArray(arr);
        }
        // Complete the reverseArray function below.
        static void reverseArray(int[] a)
        {

            int[] reverseArra = new int[a.Length];
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write($"{a[i]} ");
            }
        }
    }
}
