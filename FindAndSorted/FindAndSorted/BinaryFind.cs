using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndSorted
{
    class BinaryFind
    {
        public static int Find(int[] array, int query)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left < right)
            {
                var middle = (left + right) / 2;
                if (query <= array[middle])
                    right = middle;
                else
                    left = middle + 1;
            }
            if (array[right] == query)
                return right;
            return -1;
        }
    }
}
