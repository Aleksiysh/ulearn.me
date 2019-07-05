using System;
using System.Drawing;


namespace RoutePlanning
{
    public static class PathFinderTask
    {
        public static int[] FindBestCheckpointsOrder(Point[] checkpoints)
        {
            var bestOrder = MakeTrivialPermutation(checkpoints);

            return bestOrder;
        }

        private static int[] MakeTrivialPermutation(Point[] checkpoints)
        {
            int size = checkpoints.Length;
            var bestOrder = new int[size];
            for (int i = 0; i < bestOrder.Length; i++)
                bestOrder[i] = i;
            double pathBestOrder = getPathOrder(bestOrder, checkpoints, bestOrder.Length);
            MakePermutations(new int[size], 1, checkpoints, bestOrder);
            return bestOrder;
        }

        public static void MakePermutations(int[] permutation,
            int position, Point[] checkpoints, int[] bestOrder)
        {
            if (position == permutation.Length)
            {
                CheckPermutation(permutation, bestOrder, checkpoints);
                return;
            }

            double bestPath = getPathOrder(bestOrder, checkpoints, bestOrder.Length);
            for (int i = 0; i < permutation.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < position; j++)
                    if (permutation[j] == i)
                    {
                        found = true;
                        break;
                    }
                if (found) continue;
                permutation[position] = i;
                if (getPathOrder(permutation, checkpoints, position) > bestPath)
                    continue;
                MakePermutations(permutation, position + 1, checkpoints, bestOrder);
            }
        }

        private static double getPathOrder(int[] order, Point[] checkpoints, int end)
        {
            double pathOrder = 0;
            for (int i = 1; i < end; i++)
            {
                pathOrder += getDistance(checkpoints[order[i - 1]], checkpoints[order[i]]);
            }
            return pathOrder;
        }

        private static double getDistance(Point p1, Point p2)
        {
            return Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
        }

        private static void CheckPermutation(int[] permutation,int [] bestOrder, Point[] checkpoints)
        {
            int position = permutation.Length;
            if (getPathOrder(permutation, checkpoints, position) <
                    getPathOrder(bestOrder, checkpoints, position))
            {
                for (int i = 0; i < permutation.Length; i++)
                    bestOrder[i] = permutation[i];
            };
        }
    }
}