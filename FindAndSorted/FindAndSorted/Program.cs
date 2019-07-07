using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(BinaryFind.Find(new int[] { }, 5));// { 1, 2, 4, 5, 5, 5, 6, 7, 7, 8 }, 0));
            //Console.WriteLine( RecurseSearch.FindLeftBorder (new long[] { 1, 2, 4, 5, 5, 5, 6, 7, 7, 8 }, 19));
            //Console.WriteLine(RecurseSearch.FindElement(new long[] { 1, 2, 4, 5, 5, 5, 6, 7, 7, 8 }, 0));

            //int[] array = new int[] { 4, 3, 2, 1 };
            //Sorted.BubbleSortRange(array, 1, 2);
            //Sorted.BubbleSort(array);

            //int[] array = GenerateArray(1000);
            //int[] array = new int[] { 1, 3, 3, 4, 5, 6 };
            //Console.WriteLine(RecurseSearch.FindRightBorder(array, 2));
            //Console.WriteLine(RecurseSearch.FindRightBorder(array, 0));
            //Console.WriteLine(RecurseSearch.FindRightBorder(array, 9));
            //Console.WriteLine(RecurseSearch.FindRightBorder(new int[0], 9));

            List<string> str = new List<string> { "a", "ab", "abc" };
            Console.WriteLine(RightBorderTask.GetRightBorderIndex(str, "abc", -1, str.Count));

            //string str1 = "qwerty";
            //Console.WriteLine (str1.Contains(""));

            
            //Sorted.MergeSort(array);


            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        /// <summary>
        /// Генератор массива
        /// </summary>
        private static int[] GenerateArray(int length)
        {
            var array = new int[length];
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next();
            return array;
        }
        private static readonly Random random = new Random();
    }
}
