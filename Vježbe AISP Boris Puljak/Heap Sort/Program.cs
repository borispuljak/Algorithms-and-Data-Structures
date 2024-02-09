using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 6, 8, 3, 4, 2, 1, 7, 3, 5, 4, 5, 4, 8 };

            Console.WriteLine("Original array:");
            PrintArray(array);

            Heap.Sort(array);

            Console.WriteLine("\nSorted array:");
            PrintArray(array);
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}