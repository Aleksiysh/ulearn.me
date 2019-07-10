using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    class Book : IComparable
    {
        public string Title;
        public int Theme;
        public int CompareTo(object obj)
        {
            return
                (Theme - ((Book)obj).Theme != 0)
                ? Theme - ((Book)obj).Theme
                : Title.CompareTo(((Book)obj).Title);
        }
    }
    class ProgramBook
    {
        #region Books
        public static void Run()
        {

            Book b5 = new Book() { Title = "B", Theme = 5 };
            Book a1 = new Book() { Title = "A", Theme = 1 };
            Book c1 = new Book() { Title = "C", Theme = 1 };
            Book b3 = new Book() { Title = "B", Theme = 3 };
            Book b2 = new Book() { Title = "B", Theme = 2 };
            Book b1 = new Book() { Title = "B", Theme = 1 };
            Book a2 = new Book() { Title = "A", Theme = 2 };
            Book a9 = new Book() { Title = "A", Theme = 9 };
            Book z1 = new Book() { Title = "Z", Theme = 1 };


        }
        #endregion
    }
}
