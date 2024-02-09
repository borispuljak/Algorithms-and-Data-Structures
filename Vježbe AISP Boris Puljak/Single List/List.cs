using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_List
{
    public class List
    {
        private Node head;
        private Node tail;

        public List()
        {
            head = null;
            tail = null;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void InsertFront(object data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
        }

        public void InsertEnd(object data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }

        public object RemoveFront()
        {
            if (IsEmpty())
            {
                throw new Exception("List is empty");
            }

            object data = head.Element;
            head = head.Next;

            if (head == null)
            {
                tail = null;
            }

            return data;
        }

        public object RemoveEnd()
        {
            if (IsEmpty())
            {
                throw new Exception("List is empty");
            }

            object data = tail.Element;

            if (head == tail)
            {
                head = null;
                tail = null;
                return data;
            }

            Node current = head;
            while (current.Next != tail)
            {
                current = current.Next;
            }

            tail = current;
            tail.Next = null;
            return data;
        }

        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Element);
                current = current.Next;
            }
        }
    }
}
