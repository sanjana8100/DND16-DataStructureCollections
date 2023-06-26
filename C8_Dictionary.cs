using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND16_DataStructureCollections
{
    internal class C8_Dictionary
    {
        public Dictionary<int, string> dictionary = new Dictionary<int, string>();
        public void DictionaryMethod()
        {
            dictionary.Add(5, "Five");
            dictionary.Add(9, "Nine");
            dictionary.Add(3, "Three");
            dictionary.Add(7, "Seven");
            dictionary.Add(4, "Four");

            Console.WriteLine("The Dictionary after adding the elements: ");
            Display();

            dictionary.Remove(3);

            Console.WriteLine("The Dictionary after removing an element: ");
            Display();

            Console.WriteLine("Dictionary Contains 9 as Key ? " + dictionary.ContainsKey(9));
            Console.WriteLine("Dictionary Contains Seven as Value ? " + dictionary.ContainsValue("Seven"));
            Console.WriteLine("The number of elements in the Dictionary: " + dictionary.Count);
        }

        public void Display()
        {
            for (int index = 0; index < dictionary.Count; index++)
            {
                Console.WriteLine($"Key: {dictionary.ElementAt(index).Key}  Value: {dictionary.ElementAt(index).Value}");
            }
            Console.WriteLine("\n");
        }
    }
}
