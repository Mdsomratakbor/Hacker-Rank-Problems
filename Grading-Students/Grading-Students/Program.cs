using System;
using System.Collections.Generic;

namespace Grading_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

             gradingStudents(grades);

        }
        public static void gradingStudents(List<int> grades)
        {
            int gradResult = 0;
            for(int i=0; i<grades.Count; i++)
            {
                 gradResult = grades[i];
                if (gradResult < 38)
                {
                    Console.WriteLine(gradResult);
                    continue;
                }
                if((gradResult+2)%5==0|| (gradResult + 1) % 5 == 0)
                {
                    gradResult = ((gradResult + 2) % 5 == 0) ? gradResult + 2 : gradResult + 1;
                    
                }
                Console.WriteLine(gradResult);


            }
        }
    }
}
