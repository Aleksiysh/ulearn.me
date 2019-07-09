using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    #region Расширение класса Array
    static class ArrayExtensions
    {
        public static void Swap(this Array array, int i, int j)
        {
            object obj = array.GetValue(i);
            array.SetValue(array.GetValue(j), i);
            array.SetValue(obj, j);
        }

        public static void BubbleSort(this Array array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
                for (int j = 1; j <= i; j++)
                {
                    var element1 = (IComparable)array.GetValue(j);
                    var element0 = array.GetValue(j - 1);
                    if (element1.CompareTo(element0) < 0)
                    {
                        array.Swap(j, j - 1);
                    }
                }
        }
    }
    #endregion

    class Program
    {
        #region Метод Swap
        static void Swap(Array array, int i, int j)
        {
            object obj = array.GetValue(i);
            array.SetValue(array.GetValue(j), i);
            array.SetValue(obj, j);
        }
        #endregion

        public static void Main()
        {
            var intArr = new int[] { 2, 4, 6, 2, 6, 5 };
            var strArr = new string[] { "A", "D", "B", "F", "C" };
            var dbArr = new double[] { 1, 2, 5, 3, 7, 5 };

            intArr.BubbleSort();
            strArr.BubbleSort();
            dbArr.BubbleSort();
         
            
            Swap(intArr, 0, 1);
            intArr.Swap(2, 0);



            Array array = intArr;
            //intArr.
            array.GetValue(0);

            BubbleSort(strArr);
            BubbleSort(intArr);

            Console.ReadKey();
        }

        #region Две сортировки пузырьком для int & string
        public static void BubbleSort(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
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
                    if (array[j].CompareTo(array[j - 1]) < 0)
                    {
                        var t = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = t;
                    }
        }
        #endregion
    }
}
