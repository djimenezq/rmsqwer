using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    public class Arco
    {
        public int distancia;
        public Vertice parent;
        public Vertice child;

        public Arco(Vertice p, Vertice c, int d)
        {
            parent = p;
            child = c;
            distancia = d;
        }
    }
}
