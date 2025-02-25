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
            //WeighedGraph graph = new WeighedGraph();
            //graph.AddVertex("A");
            //graph.AddVertex("B");
            //graph.AddVertex("C");
            //graph.AddVertex("D");

            //graph.AddEdge("A", "B", 1);
            //graph.AddEdge("A", "C", 4);
            //graph.AddEdge("B", "C", 2);
            //graph.AddEdge("B", "D", 5);
            //graph.AddEdge("C", "D", 1);

            //var distances = graph.Dijkstra("A");

            //foreach (var pair in distances)
            //{
            //    Console.WriteLine($"Distancia de A a {pair.Key}: {pair.Value}");
            //}

            Graph graph = new Graph();

            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");

            graph.AddEdge("A", "B");
            graph.AddEdge("A", "C");
            graph.AddEdge("B", "C");

            Console.WriteLine("Grafo inicial:");
            graph.PrintGraph();

            graph.RemoveEdge("A", "B");
            Console.WriteLine("\nDespués de eliminar la arista A-B:");
            graph.PrintGraph();

            graph.RemoveVertex("C");
            Console.WriteLine("\nDespués de eliminar el vértice C:");
            graph.PrintGraph();
        }
    }
}
