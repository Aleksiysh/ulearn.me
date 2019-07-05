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
            //var bestOrder = MakeTrivialPermutation(checkpoints.Length);
            int[] permutation = new int[checkpoints.Length];
            var bestOrder = MakePermutations(permutation, 1);

            return bestOrder;
        }

        private static int[] MakeTrivialPermutation(int size)
        {
            var bestOrder = new int[size];
            for (int i = 0; i < bestOrder.Length; i++)
                bestOrder[i] = i;
            return bestOrder;
        }

        public static int[] MakePermutations(int[] permutation, int position)
        {
            // ���� ��������: ������� ����� ����� ������������, ��������� ��������� �������
            if (position == permutation.Length)
            {
                return permutation;
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
                MakePermutations(permutation, position + 1);
            }
        }



        private static double getDistance(Point p1, Point p2)
        {
            return Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
        }
    }
}