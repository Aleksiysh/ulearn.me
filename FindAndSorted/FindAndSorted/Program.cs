using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( BinaryFind.Find(new int[] { 1, 2, 4, 5, 5, 5, 6, 7, 7, 8 }, 5));

            Console.WriteLine("Press any key");
            Console.Read();
        }
    }
}
