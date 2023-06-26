using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND16_DataStructureCollections
{
    internal class C4_Stack
    {
        public Stack<int> stack = new Stack<int>();
        public void StackMethod()
        {
            stack.Push(54);
            stack.Push(91);
            stack.Push(35);
            stack.Push(73);
            stack.Push(46);

            Console.WriteLine("The Stack after pushing the elements: ");
            Display();

            stack.Pop();

            Console.WriteLine("The Stack after popping an element: ");
            Display();

            Console.WriteLine("Stack Contains 91 ? " + stack.Contains(91));
            Console.WriteLine("The number of elements in the Stack: " + stack.Count);
            Console.WriteLine("Peek Element: " + stack.Peek());
        }

        public void Display()
        {
            foreach (int item in stack)
            {
                Console.Write(item + " | ");
            }
            Console.WriteLine("\n");
        }
    }
}
