using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_List
{
    class Stack
    {
        private List list;

        public Stack()
        {
            list = new List();
        }

        public void Push(object data)
        {
            list.InsertFront(data);
        }

        public object Pop()
        {
            object data = list.RemoveFront();
            return data;
        }

        public bool IsEmpty()
        {
            return list.IsEmpty();
        }

        public void Display()
        {
            list.Display();
        }
    }
}
