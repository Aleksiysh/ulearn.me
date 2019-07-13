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

//*************************************************************************************************
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

        /// <summary>
        /// Перебор подмножеств
        /// </summary>        
        public static void MakeSubsets(bool[] subset, int position=0)
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
//******************************************************************************************
        /// <summary>
        /// Размещения без повторений
        /// </summary>
        public static void MakePermutations(int[] permutation, int position)
        {           
            // база рекурсии: позиция равна длине перестановки, достигнут последний элемент
            if (position == permutation.Length)
            {
                foreach (var element in permutation)
                    Console.Write(element+" ");
                Console.WriteLine(" ");
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

        /// <summary>
        /// Перебор размещений
        /// </summary>
        public static void MakeCombinations(bool[] combination,int elementLeft,int position=0)
        {
            //если яблоки кончились
            if(elementLeft == 0) 
            {
                //в остальные корзины кладем нули
                for (int i = position; i < combination.Length; i++)
                    combination[position] = false;
                //вывод результата
                foreach (var e in combination)
                    Console.Write((e ? 1 : 0 )+ " ");
                Console.WriteLine();
                return;
            }

            if (position == combination.Length)
                return;

            //Первая корзина пуста
            combination[position] = false;
            //Размещаем яблоки в корзинах начиная со следующей
            MakeCombinations(combination, elementLeft, position + 1); 
            //В первую корзину кладем яблоко
            combination[position] = true;
            //Размещаем яблоки оставшиеся (на 1 меньше) в корзинах начиная со следующей
            MakeCombinations(combination, elementLeft - 1, position + 1);
        }
    }
}
