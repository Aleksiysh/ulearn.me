using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndSorted
{
    class RecurseSearch
    {
        private static int BinSearchLeftBorder(long[] array, long value, int left, int right)
        {
            if (array.Length == 0 || array[0] >= value)
                return -1;
            if (left == right)
                return left - 1;
            var m = (left + right) / 2;
            if (array[m] < value)
                return BinSearchLeftBorder(array, value, m + 1, right);
            return BinSearchLeftBorder(array, value, left, m);
        }

        public static int FindLeftBorder(long[] arr, long value)
        {
            return BinSearchLeftBorder(arr, value, -1, arr.Length);
        }

        /// <summary>
        /// Поиск первого вхождения элемента
        /// </summary>
        public static int FindElement(long[] array, long element)
        {
            return RecursiveFindElement(array, element, 0, array.Length - 1);
        }
        private static int RecursiveFindElement(long[] array, long element, int left, int right)
        {
            if (array.Length == 0 || array[0] > element)
                return -1;

            if (right == left)
            {
                return right;
            }

            if (element <= array[(left + right) / 2])
                return RecursiveFindElement(array, element, left, (left + right) / 2);
            return RecursiveFindElement(array, element, (left + right) / 2 + 1, right);
        }
    }
}
