using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priority_Queue
{
    class Heap
    {
        private int size;
        private int last;
        private int[] priorities;

        public Heap(int size)
        {
            this.size = size;
            priorities = new int[size + 1];
            last = 0;
        }

        public void Insert(int priority)
        {
            if (last >= size)
            {
                throw new Exception("Queue is full.");
            }

            last++;
            priorities[last] = priority;
            BubbleUp(last);
        }

        public int Retrieve()
        {
            if (last == 0)
            {
                throw new Exception("Queue is empty.");
            }

            int priority = priorities[1];
            priorities[1] = priorities[last];
            last--;
            BubbleDown(1);
            return priority;
        }

        public void BubbleUp(int i)
        {
            if (i == 1) return;

            int parent = i / 2;
            if (priorities[i] > priorities[parent])
            {
                Swap(i, parent);
                BubbleUp(parent);
            }
        }

        public void BubbleDown(int i)
        {
            int leftChild = 2 * i;
            int rightChild = 2 * i + 1;
            int maxIndex = i;

            if (leftChild <= last && priorities[leftChild] > priorities[maxIndex])
            {
                maxIndex = leftChild;
            }

            if (rightChild <= last && priorities[rightChild] > priorities[maxIndex])
            {
                maxIndex = rightChild;
            }

            if (maxIndex != i)
            {
                Swap(i, maxIndex);
                BubbleDown(maxIndex);
            }
        }

        public void Swap(int i, int j)
        {
            int temp = priorities[i];
            priorities[i] = priorities[j];
            priorities[j] = temp;
        }

        public void Display()
        {
            for (int i = 1; i <= last; i++)
            {
                Console.Write(priorities[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
