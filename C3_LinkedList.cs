using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND16_DataStructureCollections
{
    internal class C3_LinkedList
    {
        public LinkedList<int> linkedList = new LinkedList<int>();
        public void LinkedListMethod()
        {
            linkedList.AddFirst(54);
            linkedList.AddLast(91);
            linkedList.AddFirst(35);
            linkedList.AddLast(73);
            linkedList.AddFirst(46);

            Console.WriteLine("The Linked List after adding the elements: ");
            Display();

            linkedList.Remove(35);

            Console.WriteLine("The Linked List after removing an element: ");
            Display();

            Console.WriteLine("Linked List Contains 91 ? " + linkedList.Contains(91));
            Console.WriteLine("The number of elements in the Linked List: " + linkedList.Count);
        }

        public void Display()
        {
            foreach (int item in linkedList)
            {
                Console.Write(item + " -> ");
            }
            Console.WriteLine("\n");
        }
    }
}
