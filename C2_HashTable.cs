using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND16_DataStructureCollections
{
    internal class C2_HashTable
    {
        public Hashtable hashtable = new Hashtable();
        public void HashTableMethod()
        {
            hashtable.Add(5, "Five");
            hashtable.Add(9, "Nine");
            hashtable.Add(3, "Three");
            hashtable.Add(7, "Seven");
            hashtable.Add(4, "Four");

            Console.WriteLine("The Hash Table after adding the elements: ");
            Display();

            hashtable.Remove(3);

            Console.WriteLine("The Hash Table after removing an element: ");
            Display();

            Console.WriteLine("Hash Table Contains 9 as Key ? " + hashtable.ContainsKey(9));
            Console.WriteLine("Hash Table Contains Seven as Value ? " + hashtable.ContainsValue(9));
            Console.WriteLine("The number of elements in the Hash Table: " + hashtable.Count);
        }

        public void Display()
        {
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"Key: {item.Key}  Value: {item.Value}");
            }
            Console.WriteLine("\n");
        }
    }
}
