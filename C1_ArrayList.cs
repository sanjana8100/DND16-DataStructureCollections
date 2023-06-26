using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND16_DataStructureCollections
{
    internal class C1_ArrayList
    {
        public ArrayList array = new ArrayList();
        public void ArrayListMethod()
        {
            array.Add(56);
            array.Add(92);
            array.Add(31);
            array.Add(74);
            array.Add(49);

            Console.WriteLine("The Array List after adding the elements: ");
            Display();

            array.Remove(31);

            Console.WriteLine("The Array List after removing an element: ");
            Display();

            Console.WriteLine("Array List Contains 92 ? " + array.Contains(92));
            Console.WriteLine("The number of elements in the Array List: " + array.Count);

            Console.WriteLine("Array List After Sorting:");
            array.Sort();
            Display();
        }

        public void Display()
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
