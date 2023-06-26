using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND16_DataStructureCollections
{
    internal class C5_Queue
    {
        public Queue<int> queue = new Queue<int>();
        public void QueueMethod()
        {
            queue.Enqueue(54);
            queue.Enqueue(91);
            queue.Enqueue(35);
            queue.Enqueue(73);
            queue.Enqueue(46);

            Console.WriteLine("The Queue after adding the elements: ");
            Display();

            queue.Dequeue();
            Console.WriteLine("The Queue after removing an element: ");
            Display();

            Console.WriteLine("Queue Contains 91 ? " + queue.Contains(91));
            Console.WriteLine("The number of elements in the Queue: " + queue.Count);
            Console.WriteLine("Peek Element: " + queue.Peek());
        }

        public void Display()
        {
            foreach (int item in queue)
            {
                Console.Write(item + " - ");
            }
            Console.WriteLine("\n");
        }
    }
}
