using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataIntegrity
{
    public class Book
    {
        public string Title { get; set; }
    }

    class TitleTask
    {
        public static void Run()
        {
            Check();
        }
        public static void Check()
        {
            var book = new Book();
            book.Title = "Structure and interpretation of computer programs";
            Console.WriteLine(book.Title);
        }
    }
}
