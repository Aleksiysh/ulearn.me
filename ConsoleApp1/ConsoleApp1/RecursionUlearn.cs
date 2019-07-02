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
            for(int i = n - 1; i >= 0; i--)
            {
                Console.Write(i + " ");
                Make(i);
            }
        }




        public static void MakePermutations(int[] permutation, int position)
        {
            if (position == permutation.Length)
            {
                foreach (var element in permutation)
                {
                    Console.Write(element);
                    Console.WriteLine(" ");
                    return;
                }
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
