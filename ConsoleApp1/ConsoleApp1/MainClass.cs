using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //ГЕНЕРАЦИЯ КОМБИНАЦИЙ ИЗ НАБОРА СИМВОЛОВ
            //char[] ch = new char[] { 'a', 'b', 'c' };
            //RecutsionTasks.MakeSubsets(ch);

            //RecursionUlearn.MakeSubsets(new bool[3]);

            //Размещение трех яблок в 5 корзин
            //RecursionUlearn.MakeCombinations(new bool[7], 5);


            //RecursionUlearn.MakeSubsets(new bool[RecursionUlearn.weights.Length], 0);

            //RecursionUlearn.MakePermutations(new int[3], 0);
            //Commivoyager.MakePermutations(new int[4], 0);

            //RecutsionTasks.TestOnSize(1);
            //RecutsionTasks.TestOnSize(2);
            //RecutsionTasks.TestOnSize(3);
            //RecutsionTasks.TestOnSize(4);

            List<string> result = CaseAlternatorTask.AlternateCharCases("a2g4d");

            Console.ReadKey();
        }
    }
}
