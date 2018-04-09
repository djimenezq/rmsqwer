using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Vertice
    {
        public string Name;
        public List<Arco> Arcos = new List<Arco>();

        public Vertice(string name)
        {
            Name = name;
        }

        public Vertice AddArco(Vertice child, int d)
        {
            Arcos.Add(new Arco
            {
                parent = this,
                child = child,
                distancia = d
            });

            if (!child.Arcos.Exists(a => a.parent == child && a.child == this))
            {
                child.AddArco(this, d);
            }

            return this;
        }
    }
}
