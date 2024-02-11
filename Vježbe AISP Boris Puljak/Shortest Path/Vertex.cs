using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortest_Path
{
    public class Vertex
    {
        public int Source { get; set; }
        public double Distance { get; set; }
        public int Index { get; set; }
        public List<Edge> Neighbors { get; }

        public Vertex(int source)
        {
            Source = source;
            Distance = double.MaxValue;
            Neighbors = new List<Edge>();
        }

        public void AddEdge(int destination, double cost)
        {
            Neighbors.Add(new Edge(destination, cost));
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            string distance = string.Format("{0,2}", (Distance == double.MaxValue) ? -1.0 : Distance);
            builder.Append("Q" + Index + " N" + Source + "(" + distance + ") --> ");
            foreach (var edge in Neighbors)
            {
                builder.Append(edge);
            }
            return builder.ToString();
        }
    }
}