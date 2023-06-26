using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND16_DataStructureCollections
{
    internal class C7_List
    {
        public List<int> list = new List<int>();
        public void ListMethod()
        {
            list.Add(54);
            list.Add(91);
            list.Add(35);
            list.Add(73);
            list.Add(46);

            Console.WriteLine("The List after adding the elements: ");
            Display();

            list.Remove(35);

            Console.WriteLine("The List after removing an element: ");
            Display();

            Console.WriteLine("List Contains 91 ? " + list.Contains(91));
            Console.WriteLine("The number of elements in the List: " + list.Count);

            Console.WriteLine("List After Sorting:");
            list.Sort();
            Display();
        }

        public void Display()
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
