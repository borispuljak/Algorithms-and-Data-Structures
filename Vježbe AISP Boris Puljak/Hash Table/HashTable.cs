using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    public class HashTable
    {
        private Node[] buckets;
        private int length;

        public HashTable(int length)
        {
            this.length = length;
            buckets = new Node[length];
        }

        public void Display()
        {
            for (int bucket = 0; bucket < buckets.Length; bucket++)
            {
                Node current = buckets[bucket];
                Console.Write(bucket + ": ");
                while (current != null)
                {
                    Console.Write("[" + current.Name + "," + current.Value + "] ");
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }

        private int Hash(string str)
        {
            int hash = 0;
            foreach (char c in str)
            {
                hash += (int)c;
            }
            return hash%length;
        }

        public void Insert(string name, int value)
        {
            int index = Hash(name);
            Node newNode = new Node(name, value, null);

            if (buckets[index] == null)
            {
                buckets[index] = newNode;
            }
            else
            {
                Node current = buckets[index];
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public int Search(string name)
        {
            int index = Hash(name);

            Node current = buckets[index];
            while (current != null)
            {
                if (current.Name == name)
                {
                    return current.Value;
                }
                current = current.Next;
            }

            throw new InvalidOperationException("Node not found in the hash table.");
        }

        public void Delete(string name)
        {
            int index = Hash(name);

            if (buckets[index] == null)
            {
                throw new InvalidOperationException("Node not found in the hash table.");
            }

            if (buckets[index].Name == name)
            {
                buckets[index] = buckets[index].Next;
                return;
            }

            Node prev = buckets[index];
            Node current = buckets[index].Next;
            while (current != null && current.Name != name)
            {
                prev = current;
                current = current.Next;
            }

            if (current == null)
            {
                throw new InvalidOperationException("Node not found in the hash table.");
            }

            prev.Next = current.Next;
        }
    }
}