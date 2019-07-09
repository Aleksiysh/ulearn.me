using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    class Program
    {
        public static void Main()
        {
            var intArr = new int[] { 2, 4, 6, 2, 6, 5 };
            BubbleSort(intArr);
            var strArr = new string[] { "A", "D", "B", "F", "C" };
            BubbleSort(strArr);



        }


        public static void BubbleSort(int[] array)
        {
            for (int i = array.Length-1; i >= 0; i--)
                for (int j = 1; j <= i; j++)
                    if (array[j] < array[j - 1])
                    {
                        var t = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = t;
                    }
        }


        public static void BubbleSort(string[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
                for (int j = 1; j <= i; j++)
                    if (array[j].CompareTo(array[j-1])<0)
                    {
                        var t = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = t;
                    }
        }
    }
}
