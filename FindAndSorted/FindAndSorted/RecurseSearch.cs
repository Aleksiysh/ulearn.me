using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndSorted
{
    class RecurseSearch
    {
        #region Левая граница
        public static int FindLeftBorder(int[] arr, int value)
        {
            return BinSearchLeftBorder(arr, value, -1, arr.Length);
        }
        private static int BinSearchLeftBorder(int[] array, int value, int left, int right)
        {
            if (/*array.Length == 0 || */ array[0] - value >= 0)
                return -1;
            if (left == right)
                return left - 1;
            var m = (left + right) / 2;
            if (array[m] - value < 0)
                return BinSearchLeftBorder(array, value, m + 1, right);
            return BinSearchLeftBorder(array, value, left, m);
        }

        #endregion

        #region Правая граница
        public static int FindRightBorder(int[] arr, int value)
        {
            return BinSearchRightBorderWile(arr, value, 0, arr.Length);
        }
        //Рекурсия
        private static int BinSearchRightBorder(int[] array, int value, int left, int right)
        {
            if (array.Length == 0 || value - array[array.Length - 1] >= 0)
                return array.Length;

            if (left == right)
                if (array[left] == value)
                    return right + 1;
                else
                    return 0;

            var m = (left + right) / 2;
            if (array[m] - value < 0)
                return BinSearchRightBorder(array, value, m + 1, right);
            return BinSearchRightBorder(array, value, left, m);
        }
        //While()
        private static int BinSearchRightBorderWile(int[] array, int value, int left, int right)
        {
            if (array.Length == 0 || value - array[array.Length - 1] >= 0)
                return array.Length;

            while (left != right)
            {
                var m = (left + right) / 2;
                if (array[m] - value < 0)
                    left = m + 1;
                else
                    right = m;
            }

            if (array[left] == value)
                return right + 1;
            else
                return 0;
        }

        #endregion

        #region Рекурсивный поиск элемента
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
        #endregion
    }
}
