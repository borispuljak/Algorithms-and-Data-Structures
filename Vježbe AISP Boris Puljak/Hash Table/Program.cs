using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable hashTable = new HashTable(3);

            hashTable.Insert("Boris", 33);
            hashTable.Insert("Grgo", 25);
            hashTable.Insert("Ivana", 22);
            hashTable.Insert("Antonia", 11);

            Console.WriteLine("Hash Table Contents:");
            hashTable.Display();

            string searchKey = "Boris";
            try
            {
                int searchResult = hashTable.Search(searchKey);
                Console.WriteLine($"Value for key '{searchKey}' found: {searchResult}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            string[] keysToDelete = { "Grgo", "Ivana" };
            foreach (string key in keysToDelete)
            {
                try
                {
                    hashTable.Delete(key);
                    Console.WriteLine($"Key '{key}' deleted successfully.");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("\nUpdated Hash Table Contents:");
            hashTable.Display();
        }
    }
}