using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(RecursionUlearn.F(0));
            

            Console.ReadKey();
        }

        public static void WriteReversed(char[] items, int startIndex = 0)
        {
            if (startIndex < items.Length - 1)
                WriteReversed(items, startIndex + 1);
            if (items.Length > 0)
                Console.Write(items[startIndex]);
        }



    }
}
