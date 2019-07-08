using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfOOP
{
    class Program
    {
        static double MyNexDouble(Random rnd,double min, double max)
        {
            return rnd.NextDouble() * (max - min) + min;
        }

        static void Main(string[] args)
        {
            var rnd = new Random();
            Console.WriteLine(MyNexDouble(rnd, 10, 20));
            Console.WriteLine(rnd.NextDouble(10, 20));
            var array = new int[] { 1, 2, 3, 4, 5 };
            array.Swap(0, 1);

            Console.ReadKey();
        }
    }

    public static class RandomExtensions
    {
        public static double NextDouble(this Random rnd, double min,double max)
        {
            return rnd.NextDouble() * (max - min) + min;
        }
    }

    public static class ArrayExtensions
    {
        public static void Swap(this int[] array, int i,int j)
        {
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
    }
}
