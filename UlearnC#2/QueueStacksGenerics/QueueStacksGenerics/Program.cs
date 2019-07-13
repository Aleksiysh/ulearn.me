using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStacksGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Стек Очередь <int>
            //var n = 30;
            //var stack = new MyStackArr();
            //for (var i = 0; i < n; i++) stack.Push(i);
            //for (var i = 0; i < n; i++) Console.Write(stack.Pop() + " ");

            //Console.WriteLine();
            //Console.WriteLine();

            //var queue = new MyQueueArr();
            //for (var i = 0; i < n; i++) queue.Enqueue(i);
            //for (var i = 0; i < n; i++) Console.Write(queue.Dequeue() + " ");

            //Console.WriteLine();
            //Console.WriteLine();

            //var queueLL = new QueueLinkList();
            //for (var i = 0; i < n; i++) queueLL.Enqueue(i);
            //for (var i = 0; i < n; i++) Console.Write(queueLL.Dequeue() + " ");

            #endregion

            #region Generic            
            //var queueG = new QueueGeneric<string>();
            //queueG.Enqueue("A");
            //queueG.Enqueue("B");
            //queueG.Enqueue("C");
            //for (var i = 0; i < 3; i++) Console.Write(queueG.Dequeue() + " ");

            //Console.WriteLine();
            //Console.WriteLine();

            //var intQueue = new QueueGeneric<int>();
            //intQueue.Enqueue(1);
            //intQueue.Enqueue(2);
            //intQueue.Enqueue(2);
            ////intQueue.Enqueue("Oops");

            //var sum = 0;
            //while (!intQueue.IsEmpty) sum += intQueue.Dequeue();
            //Console.WriteLine(sum);
            #endregion


            Console.ReadKey();
        }
    }
}
