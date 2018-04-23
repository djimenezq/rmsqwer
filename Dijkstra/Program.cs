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

            Grafo g = new Grafo();

  
            var a = g.CreateRoot("Iosefka's Clinic");//0
            var b = g.CreateVertice("Central Yahrnam");//1
            var c = g.CreateVertice("Great Bridge");//2
            var d = g.CreateVertice("Tomb of Oedon");//3
            var e = g.CreateVertice("Cathedral Ward");//4
            var f = g.CreateVertice("Old Yharnam");//5
            var g2 = g.CreateVertice("Church of the Good Chalice");//6
            var h = g.CreateVertice("Hemwick Channel Lane");//7
            var i = g.CreateVertice("Forbidden Woods");//8
            var j = g.CreateVertice("Yahargul Unseen Village");//9
            var k = g.CreateVertice("Nightmare of Mensis");//10
            var l = g.CreateVertice("Altar of Despair");//11
            var m = g.CreateVertice("Byrgenwerth");//12
            var n = g.CreateVertice("Castle Cainhurst");//13
            var o = g.CreateVertice("Lecture Building");//14
            var p = g.CreateVertice("Nightmare Frontier");//15

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

            var lista = k.ObtenerAdyacentes();

            Console.WriteLine("Adyacentes de Nightmare of Mensis");
            foreach(String na in lista)
            {
                Console.WriteLine(na);
            }

            var matrix = g.CreateAdjMatrix();
            PrintMatrix(ref matrix, 16);
            Console.WriteLine(g.FindPath(e,k));
            Console.ReadLine();
        }

        private static void PrintMatrix(ref int?[,] matrix, int Count)
        {

            for (int i = 0; i < Count; i++)
            {
                Console.Write("[ ");

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
