using System;

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

            Console.WriteLine($"a = {a} b = {b}");

            Swap(ref a, ref b);

            Console.WriteLine($"a = {a} b = {b}");

            int[] array = { 2, 3, 4, 1, 8, 6, 5, 7 };

            foreach (int num in array)
            {
                Console.Write($"{num}\n");
            }

            Console.WriteLine();

            Swap(ref array[2], ref array[3]);

            foreach (int num in array)
            {
                Console.Write($"{num}\n");
            }
        }
    }
}