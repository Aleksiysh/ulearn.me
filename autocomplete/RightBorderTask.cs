using System;
using System.Collections.Generic;
using System.Linq;

namespace Autocomplete
{
    public class RightBorderTask
    {
        /// <returns>
        /// Возвращает индекс правой границы. 
        /// То есть индекс минимального элемента, который не начинается с prefix и большего prefix.
        /// Если такого нет, то возвращает items.Length
        /// </returns>
        /// <remarks>
        /// Функция должна быть НЕ рекурсивной
        /// и работать за O(log(items.Length)*L), где L — ограничение сверху на длину фразы
        /// </remarks>
        public static int GetRightBorderIndex(IReadOnlyList<string> phrases, string prefix, int left, int right)
        {           
            if (phrases.Count == 0 ||
                string.Compare(prefix, phrases[phrases.Count - 1], StringComparison.OrdinalIgnoreCase) >= 0)
                return phrases.Count;

            var m = 0;
            while (right != left)
            {
                m = (left + right) / 2;
                if (string.Compare(prefix, phrases[m], StringComparison.OrdinalIgnoreCase) >= 0)
                    left = m + 1;
                else
                    right = m;
            }

            if (prefix == phrases[right])
                return right + 1;
            return 0;

        }
    }
}