using Single_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        private List list;

        public Queue()
        {
            list = new List();
        }

        public void Enqueue(object data)
        {
            list.InsertEnd(data);
        }

        public object Dequeue()
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
