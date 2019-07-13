using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CaseAlternatorTask
    {
        //Вызывать будут этот метод
        public static List<string> AlternateCharCases(string lowercaseWord)
        {
            var result = new List<string>();
            AlternateCharCases(lowercaseWord.ToCharArray(), 0, result);
            return result;
        }

        static void AlternateCharCases(char[] word, int startIndex, List<string> result)
        {
            // TODO
            if (startIndex == word.Length)
            {
                result.Add(new string(word));
                return;
            }
            if (Char.IsLetter(word[startIndex]) &&
                Char.ToLower(word[startIndex]) != Char.ToUpper(word[startIndex]))
            {
                word[startIndex] = Char.ToLower(word[startIndex]);
                AlternateCharCases(word, startIndex + 1, result);
                word[startIndex] = Char.ToUpper(word[startIndex]);
                AlternateCharCases(word, startIndex + 1, result);
            }
            else
                AlternateCharCases(word, startIndex + 1, result);
        }
    }
}
