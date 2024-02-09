using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_List
{
    class Node
    {
        public object Element { get; private set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }

        public Node()
        {
        }

        public Node(object data, Node nextNode, Node prevNode)
        {
            Element = data;
            Next = nextNode;
            Prev = prevNode;
        }
    }
}
