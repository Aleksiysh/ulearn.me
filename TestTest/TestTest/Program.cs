using NUnit.Framework;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TestTest
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Square(5));

            Console.ReadKey();
        }

        public static int Square(int a)
        {
            return a * a;
        }


    }


    
    [TestFixture]
    public class Tests
    {
        [TestCase(4, 2)]
        [TestCase(9, 3)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void Test1(int y,int x)
        {
           Assert.AreEqual(y, Program.Square(x), 1e-5, "OK");
           //Assert.Fail();
            


        }

    }
}

