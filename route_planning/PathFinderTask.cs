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
            var bestOrder = MakeTrivialPermutation(checkpoints);
            
            return bestOrder;
        }

        private static int[] MakeTrivialPermutation(Point[] checkpoints)
        {
            int size = checkpoints.Length;
            var bestOrder = new int[size];
            for (int i = 0; i < bestOrder.Length; i++)
                bestOrder[i] = i;
            double pathBestOrder = getPathOrder(bestOrder, checkpoints);
            MakePermutations(new int[size], 1, checkpoints, bestOrder);
            return bestOrder;
        }

        private static double getPathOrder(int[] order, Point[] checkpoints)
        {
            double pathOrder = 0;
            for(int i = 1; i < order.Length;i++) {
                pathOrder += getDistance(checkpoints[order[i-1]], checkpoints[order[i]]);
            }

            return pathOrder;

        }

        public static void MakePermutations(int[] permutation, int position, Point[] checkpoints, int[] bestOrder)
        {
            // ���� ��������: ������� ����� ����� ������������, ��������� ��������� �������
            if (position == permutation.Length)
            {
                double tmpPath = getPathOrder(permutation, checkpoints);
                if (getPathOrder(permutation, checkpoints) < getPathOrder(bestOrder, checkpoints))
                {
                    //pathBestOrder = tmpPath;
                    for (int i = 0; i < permutation.Length; i++)
                        bestOrder[i] = permutation[i];
                };
                return ;
            }
            //�� ������� ������ ��� �������� �� ������� �������,
            //���� �� ��� ��� � ������������ ������������ � �������� �� 0 �� �������
            for (int i = 0; i < permutation.Length; i++)
            {
                bool found = false;
                //���� ������� ������� ������ � ������������ � ������� �� 0 �� �������,
                //�������� �� �� ���������
                for (int j = 0; j < position; j++)
                    if (permutation[j] == i)
                    {
                        found = true;
                        break;
                    }
                if (found) continue;
                //���� �������� ��� � ������������, ������ ��� �� ������� �����
                permutation[position] = i;
                //����� ��� �� �������
                MakePermutations(permutation, position + 1, checkpoints, bestOrder);//,pathBestOrder);
            }           
        }

        private static double getDistance(Point p1, Point p2)
        {
            return Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
        }
    }
}