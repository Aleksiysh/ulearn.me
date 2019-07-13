using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStacksGenerics
{
    public class BracketExp
    {
        public static bool Check (string str)
        {
            char openBracket;
            var stack = new Stack<char>();
            foreach (var symbol in str)
            {
                
                switch (symbol)
                {
                    case '(':
                    case '[':
                        stack.Push(symbol);
                        break;
                    case ')':
                        if (stack.Count == 0) return false;
                        openBracket = stack.Pop();
                        if (openBracket != '(') return false;
                        break;
                    case ']':
                        if (stack.Count == 0) return false;
                        openBracket = stack.Pop();
                        if (openBracket != '[') return false;
                        break;                    
                }
            }
            return stack.Count == 0 ;
        }





        public static void Run()
        {
            
        }
    }
}
