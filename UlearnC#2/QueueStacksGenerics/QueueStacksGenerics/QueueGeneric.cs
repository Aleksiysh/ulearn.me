using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStacksGenerics
{
    class QueueGeneric<TValue>
    {
        QueueItemGeneric<TValue> head;
        QueueItemGeneric<TValue> tail;
        public bool IsEmpty { get { return head == null; } }

        public void Enqueue(TValue value)
        {
            var item = new QueueItemGeneric<TValue> { Value = value };
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

        public TValue Dequeue()
        {
            if (head == null)
                throw new InvalidOperationException();
            var result = head.Value;
            head = head.Next;
            if (head == null) tail = null;
            return result;
        }
    }

    class QueueItemGeneric<TValue>
    {
        public TValue Value { get; set; }
        public QueueItemGeneric<TValue> Next { get; set; }
    }
}
