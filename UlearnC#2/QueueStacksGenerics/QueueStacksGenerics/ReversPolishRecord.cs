using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStacksGenerics
{
    public class ReversPolishRecord
    {
        public static int Compute(string str)
        {
            #region Before Refactoring
            //var stack = new Stack<int>();
            //foreach (var symbol in str)
            //{
            //    if (symbol <= '9' && symbol >= '0')
            //    {
            //        stack.Push(symbol - '0');
            //        continue;
            //    }
            //    switch (symbol)
            //    {
            //        case '+':
            //            {
            //                var arg1 = stack.Pop();
            //                var arg2 = stack.Pop();
            //                stack.Push(arg1 + arg2);
            //                break;
            //            }
            //        case '*':
            //            {
            //                var arg1 = stack.Pop();
            //                var arg2 = stack.Pop();
            //                stack.Push(arg1 * arg2);
            //                break;
            //            }
            //    }
            //}

            //return stack.Pop();
            #endregion

            var stack = new Stack<int>();
            var op = new Dictionary<char, Func<int, int, int>>();
            op['+'] = (a, b) => a + b;
            op['*'] = (a, b) => a * b;
            op['-'] = (a, b) => a - b;
            op['/'] = (a, b) => a / b;

            foreach (var symbol in str)
            {
                if (symbol <= '9' && symbol >= '0')
                {
                    stack.Push(symbol - '0');
                    continue;
                }
                else if (op.Keys.Contains(symbol))
                {
                    var arg1 = stack.Pop();
                    var arg2 = stack.Pop();
                    stack.Push(op[symbol](arg2, arg1));
                }
                else throw new Exception("Unenspected symbol "+symbol);
            }

            return stack.Pop();


        }
    }
}
