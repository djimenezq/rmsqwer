using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Program
    {
        public static void Main()
        {

            var g = new Grafo();

            var a = g.CreateRoot("A");//0
            var b = g.CreateVertice("B");//1
            var c = g.CreateVertice("C");//2
            var d = g.CreateVertice("D");//3
            var e = g.CreateVertice("E");//4
            var f = g.CreateVertice("F");//5
            var g2 = g.CreateVertice("G");//6
            var h = g.CreateVertice("H");//7
            var i = g.CreateVertice("I");//8
            var j = g.CreateVertice("J");//9
            var k = g.CreateVertice("K");//10
            var l = g.CreateVertice("L");//11
            var m = g.CreateVertice("M");//12
            var n = g.CreateVertice("N");//13
            var o = g.CreateVertice("O");//14
            var p = g.CreateVertice("P");//15

            a.AddArco(b, 1)
             .AddArco(c, 1);

            b.AddArco(e, 1)
             .AddArco(d, 3);

            c.AddArco(f, 1)
             .AddArco(d, 3);

            c.AddArco(f, 1)
             .AddArco(d, 3);

            d.AddArco(h, 8);

            e.AddArco(g2, 1)
             .AddArco(h, 3);

            f.AddArco(h, 3)
             .AddArco(i, 1);

            g2.AddArco(j, 3)
             .AddArco(l, 1);

            h.AddArco(j, 8)
             .AddArco(k, 8)
             .AddArco(m, 3);

            i.AddArco(k, 3)
             .AddArco(n, 1);

            j.AddArco(o, 3);

            k.AddArco(p, 3);

            l.AddArco(o, 1);

            m.AddArco(o, 1)
             .AddArco(p, 1);

            n.AddArco(p, 1);

            var matrix = g.CreateAdjMatrix();
            PrintMatrix(ref matrix,14);
            PrintPath(g,4,10);
            Console.ReadLine();
        }

        public static void PrintPath(Grafo pg, int sourceNode, int destinationNode)
        {
            var graph = pg.CreateAdjMatrix();
            
   
            Console.Write(
                "Shortest path [{0} -> {1}]: ",
                sourceNode,
                destinationNode);

            var path = pg.DijkstraAlgorithm(sourceNode, destinationNode);

            if (path == null)
            {
                Console.WriteLine("no path");
            }
            else
            {
                int pathLength = 0;
                for (int i = 0; i < path.Count - 1; i++)
                {
                    pathLength += graph[path[i], path[i + 1]].Value;
                }

                var formattedPath = string.Join("->", path);
                Console.WriteLine("{0} (length {1})", formattedPath, pathLength);
            }
        }

        private static void PrintMatrix(ref int?[,] matrix, int Count)
        {
            Console.Write("       ");
            for (int i = 0; i < Count; i++)
            {
                Console.Write("{0}  ", (char)('A' + i));
            }

            Console.WriteLine();

            for (int i = 0; i < Count; i++)
            {
                Console.Write("{0} | [ ", (char)('A' + i));

                for (int j = 0; j < Count; j++)
                {
                    if (i == j)
                    {
                        Console.Write(" &,");
                    }
                    else if (matrix[i, j] == null)
                    {
                        Console.Write(" .,");
                    }
                    else
                    {
                        Console.Write(" {0},", matrix[i, j]);
                    }

                }
                Console.Write(" ]\r\n");
            }
            Console.Write("\r\n");
        }
    }

}
