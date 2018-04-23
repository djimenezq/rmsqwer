using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    public class Vertice
    {
        public string nombre;
        public Vertice siguiente;
        public List<Arco> Arcos;

        public Vertice(string n)
        {
            nombre = n;
            Arcos = new List<Arco>();
        }

        public Arco AddArco(Vertice child, int d)
        {
            foreach (Arco a in Arcos)
            {
                if (a.child == child && a.parent == this)
                {
                    return null;
                }
            }

            Arco newarco = new Arco(this, child, d);
            Arcos.Add(newarco);

            if (!child.Arcos.Exists(a => a.parent == child && a.child == this))
            {
                child.AddArco(this, d);
            }

            return newarco;
        }

        public List<String> ObtenerAdyacentes()
        {
            List<String> ListNombres = new List<string>();
            foreach(Arco a in Arcos)
            {
                ListNombres.Add(a.child.nombre);
            }

            return ListNombres;
        }
    }
}
