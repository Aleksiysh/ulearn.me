using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndSorted
{
    class Sorted
    {
        
        /// <summary>
        ///  Сотировка пузырьком
        /// </summary>
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        int t = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = t;
                    }
        }
        //*****************************************************************************************************
        /// <summary>
        /// Сортировка пузырьком диапазона массива
        /// </summary>
        public static void BubbleSortRange(int[] array, int left, int right)
        {
            for (int i = left; i < right; i++)
                for (int j = left; j < right; j++)
                    if (array[j] > array[j + 1])
                    {
                        var t = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = t;
                    }
        }
        //*****************************************************************************************************
        /// <summary>
        /// 
        /// </summary>
        
        public static void MergeSort(int[] array)
        {
            int[] temporaryArray = new int[array.Length];
            MergeSort_(array, 0, array.Length - 1);

        }
        private static void MergeSort_(int[] array, int start, int end, int[] temporaryArray)
        {
            if (start == end) return;
            var middle = (start + end) / 2;
            MergeSort_(array, start, middle, temporaryArray);
            MergeSort_(array, middle + 1, end, temporaryArray);
            Merge(array, start, middle, end, temporaryArray);

        }

        static void Merge(int[] array, int start, int middle, int end, int[] temporaryArray)
        {
            var leftPtr = start;
            var rightPtr = middle + 1;
            var length = end - start + 1;
            for (int i = 0; i < length; i++)
            {
                if (rightPtr > end || (leftPtr <= middle && array[leftPtr] < array[rightPtr]))
                {
                    temporaryArray[i] = array[leftPtr];
                    leftPtr++;
                }
                else
                {
                    temporaryArray[i] = array[rightPtr];
                    rightPtr++;
                }
            }
            for (int i = 0; i < length; i++)
                array[i + start] = temporaryArray[i];
        }
    }
}
