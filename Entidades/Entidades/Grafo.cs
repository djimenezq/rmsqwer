using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    public class Grafo
    {
        public Vertice Root;
        public HashTable Table;
        public List<Vertice> AllVertices;

        public Grafo()
        {
            Table = new HashTable();
            AllVertices = new List<Vertice>();
        }

        public Vertice CreateRoot(string name)
        {
            Root = CreateVertice(name);
            return Root;
        }

        public Vertice CreateVertice(string n)
        {
            Vertice v=Table.addVertice(n);
            if (v != null)
            {
                AllVertices.Add(v);
            }
            return v;
        }

        public List<Arco> ObtenerAdyacentes(String n)
        {
            Vertice v = Table.buscarVertice(n);
            if (v != null)
            {
                return v.Arcos;
            }
            else
            {
                return null;
            }
        }

        public Arco CreateArco(String norigen,String ndestino, int d)
        {
            Vertice origen = Table.buscarVertice(norigen);
            Vertice destino = Table.buscarVertice(ndestino);
    
            return origen.AddArco(destino, d);
        }


        private int?[,] CreateAdjMatrix()
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

        private List<String> DijkstraAlgorithm(int vInicial, int vFinal)
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

            var path = new LinkedList<String>();
            int? currentNode = vFinal;
            while (currentNode != null)
            {
                Vertice v = FindVertice(currentNode.Value);
                path.AddFirst(v.nombre);
                currentNode = previous[currentNode.Value];
            }

            return path.ToList();
        }

        private String FindPath(Vertice inicial, Vertice final)
        {
            
            var m = CreateAdjMatrix();
            var path = DijkstraAlgorithm(AllVertices.IndexOf(inicial), AllVertices.IndexOf(final));
            

            if (path == null)
            {
                return "No hay camino entre: "+inicial.nombre+ " -> " +final.nombre;
            }
            else
            {
                int pathLength = 0;
                for (int i = 0; i < path.Count - 1; i++)
                {
                    pathLength += m[FindIndex(path[i]), FindIndex(path[i + 1])].Value;
                }

                var formattedPath = string.Join("->", path);
                return "Camino más corto: [" + inicial.nombre + " -> " + final.nombre + "] " + formattedPath + " Distancia recorrida: " + pathLength + "km";
            }
        }

        public String EncontrarCaminoCorto(String o, String d)
        {
            Vertice origen = Table.buscarVertice(o);
            Vertice destino = Table.buscarVertice(d);
            return FindPath(origen, destino);
        }

        private int FindIndex(string nombre)
        {
            Vertice v = Table.buscarVertice(nombre);
            if(v != null)
            {
               return AllVertices.IndexOf(v);
            }
            else
            {
                return -1;
            }
        }

        private Vertice FindVertice(int indice)
        {
            return AllVertices[indice];
        }
    }
}
