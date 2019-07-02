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
            Console.WriteLine("Ghbdtn");
            char[] ch = new char[] { 'a', 'b','s','d' };
            MakeSubsets(ch);

            Console.ReadKey();
        }

        public static void WriteReversed(char[] items, int startIndex = 0)
        {
            if (startIndex < items.Length - 1)
                WriteReversed(items, startIndex + 1);
            if (items.Length > 0)
                Console.Write(items[startIndex]);
        }

        static void MakeSubsets(char[] subset, int position = 0)
        {
            if (position == subset.Length)
            {
                Console.WriteLine(new string(subset));
                return;
            }
            subset[position] = 'a';
            MakeSubsets(subset, position + 1);
            subset[position] = 'b';
            MakeSubsets(subset, position + 1);
            subset[position] = 'c';
            MakeSubsets(subset, position + 1);
        }
    }
}
