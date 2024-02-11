using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    public enum TraversalType { PreOrder, InOrder, PostOrder }
    public class Tree
    {
        private Node root;

        public Tree()
        {
            root = null;
        }

        public void Insert(int value)
        {
            if (root == null)
            {
                root = new Node(value);
            }
            else
            {
                root.Insert(value);
            }
        }

        public bool Search(int value)
        {
            Node node = Search(root, value);
            return node != null;
        }

        private Node Search(Node current, int value)
        {
            if (current == null || current.Data == value)
            {
                return current;
            }

            if (value < current.Data)
            {
                return Search(current.Left, value);
            }
            else
            {
                return Search(current.Right, value);
            }
        }

        public void Delete(int value)
        {
            Delete(ref root, value);
        }

        private void Delete(ref Node current, int value)

        {
            if (current == null)
            {
                return;
            }
            if (value < current.Data)
            {
                Node left = current.Left;
                Delete(ref left, value);
                current.Left = left;
            }
            else if (value > current.Data)
            {
                Node right = current.Right;
                Delete(ref right, value);
                current.Right = right;
            }
            else
            {
                if (current.Left == null)
                {
                    current = current.Right;
                }
                else if (current.Right == null)
                {
                    current = current.Left;
                }
                else
                {
                    int successorValue = DeleteSuccessor(current.Right, current);
                    current.Data = successorValue;
                }
            }
        }

        private int DeleteSuccessor(Node current, Node parent)
        {
            while (current.Left != null)

            {
                parent = current;
                current = current.Left;
            }
            int smallestValue = current.Data;
            if (parent.Left == current)
            {
                parent.Left = current.Right;
            }
            else
            {
                parent.Right = current.Right;
            }
            return smallestValue;
        }
        public void Traverse(TraversalType traverse)
        {
            switch (traverse)
            {
                case TraversalType.PreOrder:
                    TraversePreorder(root);
                    break;
                case TraversalType.InOrder:
                    TraverseInorder(root);
                    break;
                case TraversalType.PostOrder:
                    TraversePostorder(root);
                    break;
                default:
                    Console.WriteLine("Invalid traversal type!");
                    break;
            }
        }

        private void TraversePreorder(Node node)
        {
            if (node == null)
                return;

            Console.Write(node.Data + " ");
            TraversePreorder(node.Left);
            TraversePreorder(node.Right);
        }

        private void TraverseInorder(Node node)
        {
            if (node == null)
                return;

            TraverseInorder(node.Left);
            Console.Write(node.Data + " ");
            TraverseInorder(node.Right);
        }

        private void TraversePostorder(Node node)
        {
            if (node == null)
                return;

            TraversePostorder(node.Left);
            TraversePostorder(node.Right);
            Console.Write(node.Data + " ");
        }
    }
}