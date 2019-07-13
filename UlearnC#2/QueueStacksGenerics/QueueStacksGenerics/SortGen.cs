using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStacksGenerics
{
    public class SortGen
    {
        public static void Run()
        {
            #region До переделки
            //Sort(new int[] { 8, 2, 4, 7 });
            //Sort(new Point[] { new Point { X = 1, Y = 2 }, new Point { X = 2, Y = 1 } }); 
            #endregion

            Sorter.BubbleSort(new int[] { 8, 2, 4, 7 });
            //Sorter.Sort(new Point[] { new Point { X = 1, Y = 2 }, new Point { X = 2, Y = 1 } });
            var intArray = new int[] { 1, 2, 3 };
            intArray.BubbleSort();

            var pointArray = new Point[] { new Point { X = 1, Y = 2 }, new Point { X = 2, Y = 1 } };
            
        }

        #region До переделки
        //public static void Sort(Array array)
        //{
        //    for (int i = array.Length - 1; i > 0; i--)
        //        for (int j = 1; j <= i; j++)
        //        {
        //            object element1 = array.GetValue(j - 1);
        //            object element2 = array.GetValue(j);
        //            IComparable comparableElement1 = element1 as IComparable;
        //            if (comparableElement1.CompareTo(element2) < 0)
        //            {
        //                object temporary = array.GetValue(j);
        //                array.SetValue(array.GetValue(j - 1), j);
        //                array.SetValue(temporary, j - 1);
        //            }
        //        }
        //}
        #endregion

    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    static class Sorter
    {
        public static void BubbleSort<T>(this T[] array)
            where T : IComparable
        {
            for (int i = array.Length - 1; i > 0; i--)
                for (int j = 1; j <= i; j++)
                {
                    T element1 = array[j - 1];
                    T element2 = array[j];
                    //IComparable comparableElement1 = element1 as IComparable;
                    if (element1.CompareTo(element2) < 0)
                    {
                        T temporary = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temporary;
                    }
                }
        }

    }
}
