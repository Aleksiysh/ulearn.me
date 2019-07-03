using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Commivoyager
    {
        //матрица цен
        static int[,] prices = new int[,]
        {
            { 0, 2, 4, 7 },
            { 2, 0, 3, 1 },
            { 4, 2, 0, 1 },
            { 3, 5, 2, 0 }
        };

        static void Evaluate(int[] permitation)
        {
            int price = 0;
            for (int i = 0; i < permitation.Length; i++)
                price += prices[permitation[i], permitation[(i + 1) % permitation.Length]];
            foreach (var e in permitation)
                Console.Write(e + " ");
            Console.Write(" price = " + price);
            Console.WriteLine();

        }


        /// <summary>
        /// Размещения без повторений
        /// </summary>
        public static void MakePermutations(int[] permutation, int position)
        {
            // база рекурсии: позиция равна длине перестановки, достигнут последний элемент
            if (position == permutation.Length)
            {
                Evaluate(permutation);
                return;
            }

            //по очереди ставим все элементы на текущую позицию,
            //если их еще нет в существующей перестановки в позициях от 0 до текущей
            for (int i = 0; i < permutation.Length; i++)
            {
                bool found = false;
                //если текущий элемент найден в перестановке в позиции от 0 до текущей,
                //работаем со сл элементом
                for (int j = 0; j < position; j++)
                    if (permutation[j] == i)
                    {
                        found = true;
                        break;
                    }
                if (found) continue;
                //если елемента нет в перестановке, ставим его на текущее место
                permutation[position] = i;
                //вызов для сл позиции
                MakePermutations(permutation, position + 1);
            }
        }
    }
}
