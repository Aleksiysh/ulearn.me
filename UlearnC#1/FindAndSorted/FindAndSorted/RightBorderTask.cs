using System;
using System.Collections.Generic;
using System.Linq;

namespace FindAndSorted
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
        public static int GetRightBorderIndex(List<string> phrases,
                                    string prefix, int left, int right)
        {
            if (phrases.Count == 0 
                //||string.Compare(prefix, phrases[phrases.Count - 1], StringComparison.OrdinalIgnoreCase) >= 0
                )
                    return phrases.Count;
          
            var m = 0;
            while (right != left && right!=0)
            {
                m = (left + right) / 2;
                if (string.Compare(prefix, phrases[m], 
                            StringComparison.OrdinalIgnoreCase) >= 0
                            || phrases[m].Contains(prefix))
                    left = m + 1;
                else
                    right = m;
            }
            if (string.Compare(prefix, phrases[phrases.Count - 1], 
                                StringComparison.OrdinalIgnoreCase) == 0)
                return right;
            return right;
        }

        public static int GetLeftBorderIndex(List<string> phrases, string prefix, int left, int right)
        {
            if (phrases.Count == 0 ||
                string.Compare(phrases[0], prefix, StringComparison.OrdinalIgnoreCase) >= 0)
                return -1;

            if (right == left)
            {
                return left - 1;
            }

            var m = (left / 2 + right / 2);
            if (string.Compare(phrases[m], prefix, StringComparison.OrdinalIgnoreCase) < 0)
                return GetLeftBorderIndex(phrases, prefix, m + 1, right);
            return GetLeftBorderIndex(phrases, prefix, left, m);
        }

        public static string FindFirstByPrefix(List<string> phrases, string prefix)
        {
            var index = GetLeftBorderIndex(phrases, prefix, -1, phrases.Count) + 1;
            if (index < phrases.Count && phrases[index].StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                return phrases[index];

            return null;
        }

        /// <returns>
        /// Возвращает первые в лексикографическом порядке count (или меньше, если их меньше count) 
        /// элементов словаря, начинающихся с prefix.
        /// </returns>
        /// <remarks>Эта функция должна работать за O(log(n) + count)</remarks>
        public static string[] GetTopByPrefix(List<string> phrases, string prefix, int count)
        {
            List<string> tmpList = new List<string> { };
            var index = GetLeftBorderIndex(phrases, prefix, -1, phrases.Count);
            int i = 1;
            while (index + i < phrases.Count
                && phrases[index + i].StartsWith(prefix, StringComparison.OrdinalIgnoreCase)
                && i <= count)
            {
                tmpList.Add(phrases[index + i]);
                ++i;
            }
            // тут стоит использовать написанный ранее класс LeftBorderTask
            return tmpList.ToArray();
            //return null;
        }
        public static int GetCountByPrefix(List<string> phrases, string prefix)
        {
            int leftIndex = GetLeftBorderIndex(phrases, prefix, -1, phrases.Count);
            int rightIndex = GetRightBorderIndex(phrases, prefix, -1, phrases.Count);
            // тут стоит использовать написанные ранее классы LeftBorderTask и RightBorderTask
            return rightIndex - leftIndex - 1;
        }
    }
}