using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal class Graph
    {
        private Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();

        public void AddEdge(int u, int v)
        {
            if (!adj.ContainsKey(u))
            {
                adj[u] = new List<int>();
            }
            if (!adj.ContainsKey(v))
            {
                adj[v] = new List<int>();
            }

            adj[u].Add(v);                  // Add Neighbor
            adj[v].Add(u);
        }

        public void BFS(int start)
        {
            HashSet<int> visited = new HashSet<int>();
            Queue<int> queue = new Queue<int>();

            visited.Add(start);                             // Marking start node as visited
            queue.Enqueue(start);                           // Add start node to queue

            while (queue.Count > 0)                         // Until queue is empty
            {
                int node = queue.Dequeue();                 // take the front node 
                Console.Write(node + " ");

                foreach(var neighbor in adj[node])          
                {
                    if (!visited.Contains(neighbor))        // if neighbor not visited
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }


        
    }
}
