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
            char[] ch = new char[] { 'a', 'b', 'c' };
            RecutsionTasks.MakeSubsets(ch);


            //RecursionUlearn.MakeSubsets(new bool[RecursionUlearn.weights.Length], 0);


            Console.ReadKey();
        }
    }
}
