using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortest_Path
{
    public class FindShorthestPath : IEnumerable
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

        public void FindShortestPath(int source)
        {
            vertices[source - 1].Distance = 0;
            pot.BubbleUp(vertices[source - 1].Index);

            while (pot.last > 0)
            {
                int u = pot.queue[1];
                pot.Swap(1, pot.last);
                pot.last--;
                pot.BubbleDown(1);

                foreach (Edge edge in vertices[u].Neighbors)
                {
                    int v = edge.Destination;
                    double alt = vertices[u].Distance + edge.Cost;
                    if (alt < vertices[v - 1].Distance)
                    {
                        vertices[v - 1].Distance = alt;
                        pot.BubbleUp(vertices[v - 1].Index);
                    }
                }
            }
        }
    }
}