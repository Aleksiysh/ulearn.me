using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    class ClockWise
    {
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
                Console.WriteLine("{0} {1} {2}", e.X, e.Y, GetAngle(e));

        }
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
}
