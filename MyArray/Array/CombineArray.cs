using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    public class CombineArray
    {
        public static void Run()
        {
            var ints = new[] { 1, 2 };
            var strings = new[] { "A", "B" };
           
            Print(Combine(ints, ints));
            Print(Combine(ints, ints, ints));
            Print(Combine(ints));
            Print(Combine());
            Print(Combine(strings, strings));
            Print(Combine(ints, strings));

            Console.ReadKey();
        }

        static void Print(Array array)
        {
            if (array == null)
            {
                Console.WriteLine("null");
                return;
            }
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array.GetValue(i));
            Console.WriteLine();
        }

        public static Array Combine()
        {
            return null;
        }

        public static Array Combine(Array arr1)
        {
            return arr1;
        }

        public static Array Combine(Array arr1,Array arr2)
        {
            if (arr1 ==null || arr1.GetType().GetElementType() != arr2.GetType().GetElementType())
                return null;

            Array result = Array.CreateInstance(arr1.GetType().GetElementType(), arr1.Length + arr2.Length);
            for (int i = 0; i < arr1.Length; i++)
                result.SetValue(arr1.GetValue(i), i);
            for (int i = arr1.Length; i < arr1.Length + arr2.Length; i++)
                result.SetValue(arr2.GetValue(i-arr1.Length), i);

            return result;
        }

        public static Array Combine(Array arr1, Array arr2, Array arr3)
        {
            return Combine(Combine(arr1, arr2), arr3);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
