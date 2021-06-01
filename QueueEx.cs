using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_Queue
{
    class QueueEx
    {
        static void Main(string[] args)
        {
            Queue qu = new Queue();
            qu.Enqueue(10);
            qu.Enqueue(20);
            qu.Enqueue(30);

            Console.WriteLine(qu.Dequeue());
            Console.WriteLine(qu.Dequeue());
            Console.WriteLine(qu.Dequeue());
        }
    }
}
