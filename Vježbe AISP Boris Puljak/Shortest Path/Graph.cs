using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortest_Path
{
    
    public enum DirectionType
    {
        Directed,
        Undirected
    }

    public class Graph : IEnumerable
    {
        internal Vertex[] vertices;
        PartiallyOrderedTree pot;

        public Graph(int[] nodes)
        {
            vertices = new Vertex[nodes.Length];
            pot = new PartiallyOrderedTree(this);
            for (int i = 0; i < vertices.Length; i++)
            {
                this.vertices[i] = new Vertex(nodes[i]);
                vertices[i].Index = i + 1;
            }
        }

        public void AddEdge(int source, int destination, double cost, DirectionType direction)
        {
            if (direction == DirectionType.Undirected)
            {
                vertices[source - 1].AddEdge(destination, cost);
                vertices[destination - 1].AddEdge(source, cost);
            }
            else
            {
                vertices[source - 1].AddEdge(destination, cost);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var vertex in vertices)
            {
                yield return vertex;
            }
        }

        public void Display()
        {
            foreach (var o in this)
            {
                Console.WriteLine(o);
            }
            pot.Display();
            Console.ReadLine();
        }
    }
}
