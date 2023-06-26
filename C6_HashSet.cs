using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND16_DataStructureCollections
{
    internal class C6_HashSet
    {
        public HashSet<int> hashSet = new HashSet<int>();
        public void HashSetMethod()
        {
            hashSet.Add(54);
            hashSet.Add(91);
            hashSet.Add(35);
            hashSet.Add(73);
            hashSet.Add(46);

            Console.WriteLine("The Hash Set after adding the elements: ");
            Display();

            hashSet.Remove(35);
            Console.WriteLine("The Hash Set after removing an element: ");
            Display();

            Console.WriteLine("Hash Set Contains 91 ? " + hashSet.Contains(91));
            Console.WriteLine("The number of elements in the Hash Set: " + hashSet.Count);
        }

        public void Display()
        {
            foreach (int item in hashSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
