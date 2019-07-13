using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStacksGenerics
{
    class QueueLinkList
    {
        MyQueueItem head;
        MyQueueItem tail;

        public void Enqueue(int value)
        {
            var item = new MyQueueItem { Value = value };
            if(head == null)
            {
                head = tail = item;
            }
            else
            {
                tail.Next = item;
                tail = item;
            }
        }    
        public int Dequeue()
        {
            if (head == null)
                throw new InvalidOperationException();
            var result = head.Value;
            head = head.Next;
            if (head == null) tail = null;
            return result;
        }
    }

    class MyQueueItem
    {
        public int Value { get; set; }
        public MyQueueItem Next { get; set; }
    }
}
