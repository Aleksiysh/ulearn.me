using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RecursionUlearn
    {
        public static void Make(int n)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(i + " ");
                Make(i);
            }
        }


        /// <summary>
        /// Понимание рекурсии
        /// </summary>
        public static int F(int x)
        {
            if (x % 10 == 0) return 0;
            return 1 + F(x / 10);
        }

        /// <summary>
        /// Перебор подмножеств
        /// </summary>        
        public static void MakeSubsets(bool[] subset, int position)
        {
            if (position == subset.Length)
            {
                Evaluate(subset);
                return;
            }

            subset[position] = false;
            MakeSubsets(subset, position + 1);
            subset[position] = true;
            MakeSubsets(subset, position + 1);
        }

        /// <summary>
        /// Поиск подмножеств
        /// </summary>
        public static int[] weights = new int[] { 2, 5, 6, 2, 4, 7 };
        public static void Evaluate(bool[] subset)
        {
            var delta = 0;
            for (int i = 0; i < subset.Length; i++)
            {
                if (subset[i])
                    delta += weights[i];
                else
                    delta -= weights[i];
                foreach (var e in subset)
                    Console.Write(e ? 1 : 0);
                Console.Write(" ");
                if (delta == 0)
                    Console.Write("OK");
                Console.WriteLine();
            }
        }




        public static void MakePermutations(int[] permutation, int position)
        {
            if (position == permutation.Length)
            {
                foreach (var element in permutation)

                    Console.Write(element);
                Console.WriteLine(" ");
                return;

            }
            for (int i = 0; i < permutation.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < permutation.Length; j++)
                    if (permutation[j] == i)
                    {
                        found = true;
                        break;
                    }
                if (found) continue;
                permutation[position] = i;
                MakePermutations(permutation, position + 1);
            }
        }
    }
}
