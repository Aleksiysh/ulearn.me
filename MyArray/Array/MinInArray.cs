using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    class MinInArray
    {
        public static void Run()
        {
            Console.WriteLine(Min(new[] { 3, 6, 2, 4 }));
            Console.WriteLine(Min(new[] { "B", "A", "C", "D" }));
            Console.WriteLine(Min(new[] { '4', '2', '7' }));
        }

        static Object Min(Array array)
        {
            int min = 0;
            for (int i = 1; i < array.Length; i++)
                if (((IComparable)array.GetValue(min)).CompareTo((IComparable)array.GetValue(i)) > 0)
                    min = i;
            return array.GetValue(min);
        }
    }
}
