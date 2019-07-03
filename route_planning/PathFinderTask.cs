using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace RoutePlanning
{
	public static class PathFinderTask
	{
		public static int[] FindBestCheckpointsOrder(Point[] checkpoints)
		{
            List<int[]> result = new List<int[]> { };
            var bestOrder = new int[5];
            MakeTrivialPermutation(checkpoints.Length, result);
			return bestOrder;
		}

		private static int[] MakeTrivialPermutation(int size, List<int[]> result)
		{
			var bestOrder = new int[size];
			for (int i = 0; i < bestOrder.Length; i++)
				bestOrder[i] = i;
            MakePermutations(new int[size], 1, result);

            foreach (var purmutation in result)
            {

            }

            return result[0];
		}

        private static double getDistance(Point p1, Point p2)
        {
            return Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
        }

        public static void MakePermutations(int[] permutation, int position,List<int[]> result )
        {
            // база рекурсии: позиция равна длине перестановки, достигнут последний элемент
            if (position == permutation.Length)
            {
                result.Add(permutation.ToArray());
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
                MakePermutations(permutation, position + 1,result);
            }
        }
    }
}