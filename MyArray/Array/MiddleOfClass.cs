using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    class Book : IComparable
    {
        public string Title;
        public int Theme;
        public int CompareTo(object obj)
        {
            return
                (Theme - ((Book)obj).Theme != 0)
                ? Theme - ((Book)obj).Theme
                : Title.CompareTo(((Book)obj).Title);
        }
    }

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

        static Object Min(Array array)
        {
            int min = 0;
            for (int i = 1; i < array.Length; i++)
                if (((IComparable)array.GetValue(min)).CompareTo((IComparable)array.GetValue(i)) > 0)
                    min = i;
            return array.GetValue(min);
        }
        class ClockwiseComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                return GetAngle((Point)x).CompareTo(GetAngle((Point)y));
            }

            static double GetAngle(Point point)
            {
                if (point.Y == 0)
                    return (point.X > 0) ? 0 : 180;
                if (point.X == 0)
                    return (point.Y > 0) ? 90 : 270;
                var a = Math.Atan(point.Y / point.X) * 180 / Math.PI;
                a = (point.Y > 0) ? a : a + 180;
                return a;
            }
        }
        public static double GetAngle(Point point)
        {
            if (point.Y == 0)
                return (point.X > 0) ? 0 : 180;
            if (point.X == 0)
                return (point.Y > 0) ? 90 : 270;
            var a = Math.Atan(point.Y / point.X) * 180 / Math.PI;
            a = (point.Y > 0) ? a : a + 180;
            return a;
        }


        public static void Run()
        {
            #region Среднее трех
            //Console.WriteLine(MiddleOfThree(2, 5, 4));
            //Console.WriteLine(MiddleOfThree(3, 1, 2));
            //Console.WriteLine(MiddleOfThree(3, 5, 9));
            //Console.WriteLine(MiddleOfThree("B", "Z", "A"));
            //Console.WriteLine(MiddleOfThree(3.45, 2.67, 3.12));
            #endregion
            #region MinElement
            Console.WriteLine(Min(new[] { 3, 6, 2, 4 }));
            Console.WriteLine(Min(new[] { "B", "A", "C", "D" }));
            Console.WriteLine(Min(new[] { '4', '2', '7' }));
            #endregion
            #region Books
            Book b5 = new Book() { Title = "B", Theme = 5 };
            Book a1 = new Book() { Title = "A", Theme = 1 };
            Book c1 = new Book() { Title = "C", Theme = 1 };
            Book b3 = new Book() { Title = "B", Theme = 3 };
            Book b2 = new Book() { Title = "B", Theme = 2 };
            Book b1 = new Book() { Title = "B", Theme = 1 };
            Book a2 = new Book() { Title = "A", Theme = 2 };
            Book a9 = new Book() { Title = "A", Theme = 9 };
            Book z1 = new Book() { Title = "Z", Theme = 1 };

            #endregion
            #region По часовой стрелке
            var array = new[]
    {
        new Point { X = 1, Y = 0 },
        new Point { X = -1, Y = 0 },
        new Point { X = 0, Y = 1 },
        new Point { X = 0, Y = -1 },
        new Point { X = 0.01, Y = 1 }
    };
            Array.Sort(array, new ClockwiseComparer());
            foreach (Point e in array)
                Console.WriteLine("{0} {1} {2}", e.X, e.Y,GetAngle(e));






            #endregion
        }

    }
}
