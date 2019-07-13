using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataIntegrity
{
    class RefTask
    {
        public static void SkipSpaces(string text, ref int pos)
        {
            while (pos < text.Length && char.IsWhiteSpace(text[pos]))
                pos++;
        }

        public static string ReadNumber(string text, ref int pos)
        {
            var start = pos;
            while (pos < text.Length && char.IsDigit(text[pos]))
                pos++;
            return text.Substring(start, pos - start);
        }

        public static void WriteAllNumbersFromText(string text)
        {
            int pos = 0;
            while (true)
            {
                SkipSpaces(text, ref pos);
                // skip spaces
                var num = ReadNumber(text, ref pos); // read next number
                if (num == "") break;
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        public static void Run()
        {
            string text = "    464asda3sf4  ere433";
            WriteAllNumbersFromText(text);
        }
    }
}
