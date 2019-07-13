using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    class MiddleOfClass
    {
        public static int MiddleOf(int a, int b, int c)
        {
            if (a >= b && b >= c) return b;
            if (a >= c && c >= b) return c;
            if (c >= b && b >= a) return b;
            if (c >= a && a >= b) return a;
            if (b >= a && a >= c) return a;
            if (b >= c && c >= a) return c;
            return 0;
        }

        static object MiddleOfThree(object a, object b, object c)
        {
            var a1 = (IComparable)a;
            var b1 = (IComparable)b;
            var c1 = (IComparable)c;
            if (a1.CompareTo(b1) >= 0 && b1.CompareTo(c1) >= 0) return b;
            if (a1.CompareTo(c1) >= 0 && c1.CompareTo(b1) >= 0) return c;
            if (c1.CompareTo(b1) >= 0 && b1.CompareTo(a1) >= 0) return b;
            if (c1.CompareTo(a1) >= 0 && a1.CompareTo(b1) >= 0) return a;
            if (b1.CompareTo(a1) >= 0 && a1.CompareTo(c1) >= 0) return a;
            if (b1.CompareTo(c1) >= 0 && c1.CompareTo(a1) >= 0) return c;
            return 0;
        }

        public static void Run()
        {
            Console.WriteLine(MiddleOfThree(2, 5, 4));
            Console.WriteLine(MiddleOfThree(3, 1, 2));
            Console.WriteLine(MiddleOfThree(3, 5, 9));
            Console.WriteLine(MiddleOfThree("B", "Z", "A"));
            Console.WriteLine(MiddleOfThree(3.45, 2.67, 3.12));
        }
    }
}
