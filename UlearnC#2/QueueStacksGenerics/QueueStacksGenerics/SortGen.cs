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
            Sort(new int[] {8, 2, 4, 7 });
            Sort(new Point[] { new Point { X = 1, Y = 2 }, new Point { X = 2, Y = 1 } });
        }

        public static void Sort(Array array)
        {
            for(int i = array.Length-1;i>0;i--)
                for(int j = 1; j <= i; j++)
                {
                    object element1 = array.GetValue(j - 1);
                    object element2 = array.GetValue(j);
                    IComparable comparableElement1 =element1 as IComparable;
                    if (comparableElement1.CompareTo(element2) < 0)
                    {
                        object temporary = array.GetValue(j);
                        array.SetValue(array.GetValue(j - 1), j);
                        array.SetValue(temporary, j - 1);
                    }
                }
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Sorter<T>
    {

    }
}
