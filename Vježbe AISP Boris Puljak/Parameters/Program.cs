using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int a = 1, b = 2;

            Console.WriteLine($"Prije zamjene: a = {a} b = {b}");

            Swap(ref a, ref b);

            Console.WriteLine($"Poslije zamjene: a = {a} b = {b}");

            int[] array = { 2, 3, 4, 1, 8, 6, 5, 7 };

            Console.WriteLine("\nNiz prije zamjene:");

            foreach (int num in array)
            {
                Console.Write(num+"\n");
            }

            Swap(ref array[2], ref array[3]);

            Console.WriteLine("\nNiz nakon zamjene:");

            foreach (int num in array)
            {
                Console.Write(num+"\n");
            }
        }
    }
}