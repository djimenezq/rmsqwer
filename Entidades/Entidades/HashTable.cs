using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    public class HashTable
    {
        private Vertice[] tabla;
        private const int TABLASIZE = 25;

        public HashTable()
        {
            tabla = new Vertice[TABLASIZE];
        }

        public Vertice addVertice(String nombre)
        {
            Vertice v = buscarVertice(nombre);
            if (v == null)
            {
                v = new Vertice(nombre);
                int indice = hashfunction(nombre);
                if (tabla[indice] == null)
                {
                    tabla[indice] = v;
                }
                else
                {
                    Vertice aux = tabla[indice];
                    while (aux.siguiente != null)
                    {
                        aux = aux.siguiente;
                    }

                    aux.siguiente = v;
                }

                return v;
            }
            else
            {
                return null;
            }

        }

        public Vertice buscarVertice(String nombre)
        {
            int indice = hashfunction(nombre);
            Vertice aux = tabla[indice];

            while(aux != null && aux.nombre != nombre)
            {
                aux = aux.siguiente;
            }

            return aux;
            
        }

        private int hashfunction(String nombre)
        {
            int cont = 0;

            foreach (char c in nombre)
            {
                int unicode = c;
                cont += unicode;
            }
            return cont % TABLASIZE;
        }
    }
}
