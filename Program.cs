using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphChiCharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            graph.AddVertex("A");
            graph.AddVertex("B");

            graph.AddEdge("A", "B");

            graph.PrintGraph();
        }
    }
}
