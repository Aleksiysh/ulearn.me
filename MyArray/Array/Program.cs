using System;
using System.Collections;

namespace MyArray
{
    class Point
    {
        public double X;
        public double Y;

        //double DistanseToZero(Point point)
        //{
        //    return Math.Sqrt(point.X * point.X + point.Y * point.Y);
        //}

        //public int CompareTo(object obj)
        //{
        //    var point = (Point)obj;
        //    double thisDistance =DistanseToZero(this);
        //    double thatDistance = DistanseToZero(point);
        //    return thisDistance.CompareTo(thatDistance);
        //}
    }
    #region Сравнение по удаленности от центра
    class DistanceToZeroComparer : IComparer
    {
        double DistanseToZero(Point point)
        {
            return Math.Sqrt(point.X * point.X + point.Y * point.Y);
        }

        public int Compare(object x, object y)
        {
            return DistanseToZero((Point)x).CompareTo(DistanseToZero((Point)y));
        }
    }
    #endregion

    class XDecreasingComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return -((Point)x).X.CompareTo(((Point)y).X);
        }
    }

    #region Расширение класса Array
    static class ArrayExtensions
    {
        public static void Swap(this Array array, int i, int j)
        {
            object obj = array.GetValue(i);
            array.SetValue(array.GetValue(j), i);
            array.SetValue(obj, j);
        }

        public static void BubbleSort(this Array array, IComparer comparer)
        {

            for (int i = array.Length - 1; i >= 0; i--)
                for (int j = 1; j <= i; j++)
                {
                    var element1 = array.GetValue(j);
                    var element0 = array.GetValue(j - 1);
                    if (comparer.Compare(element1, element0) < 0)
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
            MiddleOfClass.Run();

            #region Теория
            var intArr = new int[] { 2, 4, 6, 2, 6, 5 };
            var strArr = new string[] { "A", "D", "B", "F", "C" };
            var dbArr = new double[] { 1, 2, 5, 3, 7, 5 };
            var pointArray = new Point[]
            {
                new Point{X=3,Y=3},
                new Point{X=1,Y=1},
                new Point{X=2,Y=2}
            };

            //intArr.BubbleSort();
            //strArr.BubbleSort();
            //dbArr.BubbleSort();
            pointArray.BubbleSort(new DistanceToZeroComparer());


            Swap(intArr, 0, 1);
            intArr.Swap(2, 0);



            Array array = intArr;
            //intArr.
            array.GetValue(0);

            BubbleSort(strArr);
            BubbleSort(intArr);

            Console.ReadKey();
            #endregion
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
