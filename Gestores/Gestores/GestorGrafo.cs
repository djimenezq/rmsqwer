using Dijkstra;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestores.Gestores
{
    public class GestorGrafo
    {
        public Grafo g;

        public GestorGrafo()
        {
            g = new Grafo();
            InicializarGrafo();
        }
        public List<String> GetAllVerticesName()
        {
            var list = g.AllVertices;
            List<String> listnombres=new List<String>();
            foreach(Vertice v in list)
            {
                listnombres.Add(v.nombre);
            }

            return listnombres;
        }

        public Vertice AddVertice(String n)
        {
            Vertice v = g.CreateVertice(n);
            return v;
        }

        public Arco AddArco(String no, String nd, int d)
        {
            Arco a = g.CreateArco(no, nd, d);
            return a;
        }

        public List<Arco> buscarAdyacentes(String n)
        {
            List<Arco> l = g.ObtenerAdyacentes(n);
            return l;

        }

        public String calcularCamino(String o, String d)
        {
            return g.EncontrarCaminoCorto(o,d);
        }
        public void InicializarGrafo()
        {
            var me = g.CreateRoot("Maine");
            var nh = g.CreateVertice("New Hampshire");
            var vt = g.CreateVertice("Vermont");
            var ny = g.CreateVertice("New York");
            var ma = g.CreateVertice("Massachusetts");
            var ct = g.CreateVertice("Connecticut");
            var ri = g.CreateVertice("Rhode Island");
            var nj = g.CreateVertice("New Jersey");
            var pa = g.CreateVertice("Pennsylvania");
            var de = g.CreateVertice("Delaware");
            var md = g.CreateVertice("Maryland");
            var oh = g.CreateVertice("Ohio");
            var wv = g.CreateVertice("West Virginia");
            var va = g.CreateVertice("Virginia");
            var nc = g.CreateVertice("North Carolina");
            var sc = g.CreateVertice("South Carolina");
            var fl = g.CreateVertice("Florida");
            var ga = g.CreateVertice("Georgia");
            var mi = g.CreateVertice("Michigan");
            var in1 = g.CreateVertice("Indiana");
            var ky = g.CreateVertice("Kentucky");
            var tn = g.CreateVertice("Tennessee");
            var al = g.CreateVertice("Alabama");
            var il = g.CreateVertice("Illinois");
            var ms = g.CreateVertice("Mississippi");

            me.AddArco(nh, 285);

            nh.AddArco(vt, 172);
            nh.AddArco(ma, 89);

            vt.AddArco(ma, 258);
            vt.AddArco(ny, 443);

            ny.AddArco(ma, 289);
            ny.AddArco(ct, 125);
            ny.AddArco(nj,80);
            ny.AddArco(pa,274);

            ma.AddArco(ct, 167);
            ma.AddArco(ri, 92);

            ct.AddArco(ri, 134);

            nj.AddArco(pa,268);
            nj.AddArco(de,160);

            pa.AddArco(de,292);
            pa.AddArco(md,244);
            pa.AddArco(wv,402);
            pa.AddArco(oh,490);

            md.AddArco(de,98);
            md.AddArco(wv,335);
            md.AddArco(va,251);

            oh.AddArco(mi,486);
            oh.AddArco(in1,275);
            oh.AddArco(ky,310);
            oh.AddArco(wv,292);

            wv.AddArco(va,204);
            wv.AddArco(ky,345);

            va.AddArco(ky,497);
            va.AddArco(tn,460);
            va.AddArco(nc,188);

            nc.AddArco(tn,685);
            nc.AddArco(ga,536);
            nc.AddArco(sc,290);

            sc.AddArco(ga,246);

            ga.AddArco(tn,504);
            ga.AddArco(al,378);
            ga.AddArco(fl,516);

            fl.AddArco(al,732);

            mi.AddArco(in1,452);

            in1.AddArco(ky,314);
            in1.AddArco(il,280);

            ky.AddArco(il,540);
            ky.AddArco(tn,330);

            tn.AddArco(al,356);
            tn.AddArco(ms,437);

            al.AddArco(ms,235);
        }
  
    }
}
