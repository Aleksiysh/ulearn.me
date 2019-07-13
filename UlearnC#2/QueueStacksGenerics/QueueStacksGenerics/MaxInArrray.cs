using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStacksGenerics
{
    class MaxInArrray
    {
        public static void Run() 
            {
            Console.WriteLine(Max(new int[0]));
            Console.WriteLine(Max(new[] { 3 }));
            Console.WriteLine(Max(new[] { 3, 1, 2 }));
            Console.WriteLine(Max(new[] { "A", "B", "C" }));
        }
        
        static T Max<T>(T[] array)
            where T:IComparable
        {
            if (array.Length == 0) return default(T);
            T max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max.CompareTo(array[i])<0)
                    max = array[i];
            }
            return max;
        }



    }

}
