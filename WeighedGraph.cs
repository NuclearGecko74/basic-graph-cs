using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GraphChiCharp
{
    class WeighedGraph
    {
        private Dictionary<string, Dictionary<string, int>> adjList;

        public WeighedGraph()
        {
            adjList = new Dictionary<string, Dictionary<string, int>>();
        }

        public bool AddVertex(string vertex)
        {
            if (!adjList.ContainsKey(vertex))
            {
                adjList[vertex] = new Dictionary<string, int>();
                return true;
            }
            return false;
        }

        public bool AddEdge(string vertex1, string vertex2, int weight)
        {
            if (adjList.ContainsKey(vertex1) && adjList.ContainsKey(vertex2))
            {
                adjList[vertex1][vertex2] = weight;
                adjList[vertex2][vertex1] = weight;
                return true;
            }
            return false;
        }

        public Dictionary<string, int> Dijkstra(string startVertex)
        {
            var distances = new Dictionary<string, int>();
            var visited = new HashSet<string>();
            var previousVertices = new Dictionary<string, string>();

            foreach (var vertex in adjList.Keys)
            {
                distances[vertex] = int.MaxValue;
                previousVertices[vertex] = null;
            }
            distances[startVertex] = 0;

            var nodes = new List<string>(adjList.Keys);

            while (nodes.Count > 0)
            {
                string currentVertex = null;
                int smallestDistance = int.MaxValue;

                foreach (var node in nodes)
                {
                    if (distances[node] < smallestDistance)
                    {
                        smallestDistance = distances[node];
                        currentVertex = node;
                    }
                }

                if (currentVertex == null)
                    break;

                nodes.Remove(currentVertex);
                visited.Add(currentVertex);

                foreach (var neighbor in adjList[currentVertex])
                {
                    if (visited.Contains(neighbor.Key))
                        continue;

                    int newDist = distances[currentVertex] + neighbor.Value;
                    if (newDist < distances[neighbor.Key])
                    {
                        distances[neighbor.Key] = newDist;
                        previousVertices[neighbor.Key] = currentVertex;
                    }
                }
            }

            return distances;
        }

        public void PrintGraph()
        {
            foreach (var pair in adjList)
            {
                string vertex = pair.Key;
                Console.Write(vertex + ": [ ");
                foreach (var edge in pair.Value)
                {
                    Console.Write(edge.Key + "(" + edge.Value + ") ");
                }
                Console.WriteLine("]");
            }
        }
    }
}
