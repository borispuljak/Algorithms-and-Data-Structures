using System;

namespace Searching
{
    class Program
    {
        static int SequentialSearch(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    return i;
            }
            return -1;
        }

        static int BinarySearch(int[] array, int value)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (array[mid] == value)
                    return mid;

                if (array[mid] < value)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return -1;
        }

        static int BinarySearchRecursive(int[] array, int value, int low, int high)
        {
            if (low <= high)
            {
                int mid = (low + high) / 2;

                if (array[mid] == value)
                    return mid;

                if (array[mid] < value)
                    return BinarySearchRecursive(array, value, mid + 1, high);
                else
                    return BinarySearchRecursive(array, value, low, mid - 1);
            }

            return -1;
        }

        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };

            // Sequential Search
            int index = SequentialSearch(array, 6);
            Console.WriteLine($"Sequential Search Result: {index}");

            // Binary Search
            index = BinarySearch(array, 6);
            Console.WriteLine($"Binary Search Result: {index}");

            // Binary Search with specific range
            index = BinarySearchRecursive(array, 6, 0, 6);
            Console.WriteLine($"Binary Search (Range) Result: {index}");
        }
    }
}