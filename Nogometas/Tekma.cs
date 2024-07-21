using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometas
{
    internal class Tekma
    {
        Klub domaci;
        Klub gostje;
        int domaciGoli;
        int gostjeGoli;
        DateTime datum;
        Stadion stadion;
        List<Igralec> domaciIgralci;
        List<Igralec> gostjeIgralci;

        public Tekma(Klub domaci, Klub gostje, DateTime datum, Stadion stadion)
        {
            this.domaci = domaci;
            this.gostje = gostje;
            this.datum = datum;
            this.stadion = stadion;
            domaciGoli = 0;
            gostjeGoli = 0;
            domaciIgralci = new List<Igralec>();
            gostjeIgralci = new List<Igralec>();
        }

        public Tekma()
        {
            domaci = null;
            gostje = null;
            datum = DateTime.Now;
            stadion = null;
            domaciGoli = 0;
            gostjeGoli = 0;
            domaciIgralci = new List<Igralec>();
            gostjeIgralci = new List<Igralec>();
        }
    }
}
