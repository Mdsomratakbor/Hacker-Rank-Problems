using System;

namespace A_Very_Big_Sum_4_7_2021_
{
    class Program
    {
        static long SumArrayElement(int [] array)
        {
            long output=0;
            for(int i=0; i<array.Length; i++)
            {
                output += array[i];
            }
            return output;
        }
        static void Main(string[] args)
        {
            int arrayElement = Convert.ToInt32(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');
            int i = 0;
            int[] array = new int[arrayElement];
            while (i<arrayElement)
            {
                array[i] = Convert.ToInt32(inputs[i]);
                i++;
            }
            Console.WriteLine(SumArrayElement(array));
        }
    }
}
