using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStacksGenerics
{
    public class BracketExp
    {
        public static bool Check(string str)
        {
            #region Refacroting
            //char openBracket;
            //var stack = new Stack<char>();
            //foreach (var symbol in str)
            //{

            //    switch (symbol)
            //    {
            //        case '(':
            //        case '[':
            //            stack.Push(symbol);
            //            break;
            //        case ')':
            //            if (stack.Count == 0) return false;
            //            openBracket = stack.Pop();
            //            if (openBracket != '(') return false;
            //            break;
            //        case ']':
            //            if (stack.Count == 0) return false;
            //            openBracket = stack.Pop();
            //            if (openBracket != '[') return false;
            //            break;                    
            //    }
            //}
            //return stack.Count == 0 ; 
            #endregion


            var stack = new Stack<char>();
            var dict = new Dictionary<char, char>();
            dict['['] = ']';
            dict['('] = ')';
            dict['{'] = '}';
            dict['<'] = '>';
            char openBracket;
            foreach (var symbol in str)
            {                
                if (dict.Keys.Contains(symbol))
                    stack.Push(symbol);
                else if (dict.Values.Contains(symbol))
                {
                    if (stack.Count == 0) return false;
                    openBracket = stack.Pop();
                    if (dict[openBracket] != symbol) return false;
                }                
            }
            return stack.Count == 0;
        }





        public static void Run()
        {

        }
    }
}
