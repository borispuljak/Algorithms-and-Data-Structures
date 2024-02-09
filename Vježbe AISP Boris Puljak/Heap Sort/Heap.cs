using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap_Sort
{
    class Heap
    {
        public static void Sort(int[] array)
        {
            Heapify(array);
            Arrange(array);
        }

        public static void Heapify(int[] array)
        {
            int n = array.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                BubbleDown(array, i, n);
            }
        }

        public static void Arrange(int[] array)
        {
            int n = array.Length;
            for (int i = n - 1; i > 0; i--)
            {
                Swap(array, 0, i);
                BubbleDown(array, 0, i);
            }
        }

        public static void BubbleDown(int[] array, int i, int last)
        {
            int leftChild = 2 * i + 1;
            int rightChild = 2 * i + 2;
            int maxIndex = i;

            if (leftChild < last && array[leftChild] > array[maxIndex])
            {
                maxIndex = leftChild;
            }

            if (rightChild < last && array[rightChild] > array[maxIndex])
            {
                maxIndex = rightChild;
            }

            if (maxIndex != i)
            {
                Swap(array, i, maxIndex);
                BubbleDown(array, maxIndex, last);
            }
        }

        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
