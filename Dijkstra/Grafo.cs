using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Grafo
    {
        public Vertice Root;
        public List<Vertice> AllVertices = new List<Vertice>();

        public Vertice CreateRoot(string name)
        {
            Root = CreateVertice(name);
            return Root;
        }

        public Vertice CreateVertice(string name)
        {
            var n = new Vertice(name);
            AllVertices.Add(n);
            return n;
        }

        public int?[,] CreateAdjMatrix()
        {
            int?[,] adj = new int?[AllVertices.Count, AllVertices.Count];

            for (int i = 0; i < AllVertices.Count; i++)
            {
                Vertice v1 = AllVertices[i];

                for (int j = 0; j < AllVertices.Count; j++)
                {
                    Vertice v2 = AllVertices[j];

                    var arc = v1.Arcos.FirstOrDefault(a => a.child == v2);

                    if (arc != null)
                    {
                        adj[i, j] = arc.distancia;
                    }
                }
            }
            return adj;
        }

        public List<int> DijkstraAlgorithm(int vInicial, int vFinal)
        {
            var graph = CreateAdjMatrix();
            var n =graph.GetLength(0);

            var distance = new int[n];
            for (int i = 0; i < n; i++)
            {
                distance[i] = int.MaxValue;
            }

            distance[vInicial] = 0;

            var used = new bool[n];
            var previous = new int?[n];

            while (true)
            {
                var minDistance = int.MaxValue;
                var minNode = 0;
                for (int i = 0; i < n; i++)
                {
                    if (!used[i] && minDistance > distance[i])
                    {
                        minDistance = distance[i];
                        minNode = i;
                    }
                }

                if (minDistance == int.MaxValue)
                {
                    break;
                }

                used[minNode] = true;

                for (int i = 0; i < n; i++)
                {
                    if (graph[minNode, i] > 0)
                    {
                        var shortestToMinNode = distance[minNode];
                        var distanceToNextNode = graph[minNode, i];

                        var totalDistance = shortestToMinNode + distanceToNextNode;

                        if (totalDistance < distance[i])
                        {
                            distance[i] = totalDistance.Value;
                            previous[i] = minNode;
                        }
                    }
                }
            }

            if (distance[vFinal] == int.MaxValue)
            {
                return null;
            }

            var path = new LinkedList<int>();
            int? currentNode = vFinal;
            while (currentNode != null)
            {
                path.AddFirst(currentNode.Value);
                currentNode = previous[currentNode.Value];
            }

            return path.ToList();
        }
    }
}
