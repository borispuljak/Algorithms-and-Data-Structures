using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data)
        {
            Data = data;
            Left = Right = null;
        }

        public void Insert(int value)
        {
            if (value < Data)
            {
                if (Left == null)
                {
                    Left = new Node(value);
                }
                else
                {
                    Left.Insert(value);
                }
            }
            else if (value > Data)
            {
                if (Right == null)
                {
                    Right = new Node(value);
                }
                else
                {
                    Right.Insert(value);
                }
            }
        }
    }
}
