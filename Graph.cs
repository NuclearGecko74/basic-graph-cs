using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphChiCharp
{
    class Graph
    {
        private Dictionary<string, HashSet<string>> adjList;

        public Graph()
        {
            adjList = new Dictionary<string, HashSet<string>>();
        }

        public bool AddVertex(string vertex)
        {
            if(!adjList.ContainsKey(vertex))
            {
                adjList[vertex] = new HashSet<string>();
                return true;
            }
            return false;
        }

        public bool AddEdge(string vertex1, string vertex2)
        {
            if (adjList.ContainsKey(vertex1) && adjList.ContainsKey(vertex2))
            {
                adjList[vertex1].Add(vertex2);
                adjList[vertex2].Add(vertex1);
                return true;
            }
            return false;
        }

        public bool RemoveEdge(string vertex1, string vertex2)
        {
            if (adjList.ContainsKey(vertex1) && adjList.ContainsKey(vertex2))
            {
                adjList[vertex1].Remove(vertex2);
                adjList[vertex2].Remove(vertex1);
                return true;
            }
            return false;
        }

        public bool RemoveVertex(string vertex)
        {
            if (adjList.ContainsKey(vertex))
            {
                foreach(var otherVertex in adjList[vertex])
                {
                    adjList[otherVertex].Remove(vertex);
                }
                adjList.Remove(vertex);
                return true;
            }
            return false;
        }

        public void PrintGraph()
        {
            foreach (var pair in adjList)
            {
                string vertex = pair.Key;
                HashSet<string> edges = pair.Value;

                Console.Write(vertex + ": [ ");
                foreach (var edge in edges)
                {
                    Console.Write(edge + " ");
                }
                Console.WriteLine("]");
            }
        }
    }
}
