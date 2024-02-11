using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_List
{
    public class BllList
    {
        private Node head;
        private int count;

        public int Count { get { return count; } }

        public BllList()
        {
            head = new Node();
            head.Next = head;
            head.Prev = head;
        }

        private bool IsEmpty()
        {
            return count == 0;
        }

        public void Append(object data)
        {
            Node newNode = new Node(data, head, head.Prev);
            head.Prev.Next = newNode;
            head.Prev = newNode;
            count++;
        }

        private Node Find(object data)
        {
            Node current = head.Next;
            while (current != head)
            {
                if (current.Element.Equals(data))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public void Remove(object data)
        {
            Node nodeToRemove = Find(data);
            if (nodeToRemove == null)
            {
                throw new Exception("Element not found in the list.");
            }

            nodeToRemove.Prev.Next = nodeToRemove.Next;
            nodeToRemove.Next.Prev = nodeToRemove.Prev;
            count--;
        }

        public bool Search(object data)
        {
            return Find(data) != null;
        }

        public void Display()
        {
            Node current = head.Next;
            while (current != head)
            {
                Console.WriteLine(current.Element);
                current = current.Next;
            }
        }
    }
}