using System;
using System.Collections.Generic;
using System.Linq;

namespace Designer_PDF_Viewer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
      ;
            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);
            Console.WriteLine(result);
        }
        // Complete the designerPdfViewer function below.
        static int designerPdfViewer(int[] h, string word)
        {
            char[] words = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v','w','x','y','z' };
            int tallestWord = 0;
            List<int> myWordArray = new List<int>();
                for(int i=0; i<word.Length; i++)
            {
                for(int j=0; j < words.Length; j++)
                {
                    if(word[i]== words[j])
                    {
                        myWordArray.Add(h[j]);
                        break;
                    }
                }
            }
            tallestWord = myWordArray.Max();
            tallestWord = myWordArray.Count * tallestWord * 1;
            return tallestWord;
        }
    }
}
