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
        Trener domaciTrener;
        Trener gostjeTrener;
        Dictionary<Igralec, Statistika> domaciIgralci;
        Dictionary<Igralec, Statistika> gostjeIgralci;

        public Tekma(Klub domaci, Klub gostje, DateTime datum, Stadion stadion, Dictionary<Igralec, Statistika> domaciIgralci, Dictionary<Igralec, Statistika> gostjeIgralci)
        {
            this.domaci = domaci;
            this.gostje = gostje;
            this.datum = datum;
            this.stadion = stadion;
            domaciGoli = 0;
            gostjeGoli = 0;
            this.domaciIgralci = domaciIgralci;
            this.gostjeIgralci = gostjeIgralci;
        }

        public void DodajGolDomaci(Igralec igralec)
        {
            domaciGoli++;
            domaciIgralci[igralec].DodajGol();
        }

        public void DodajGolGostje(Igralec igralec)
        {
            gostjeGoli++;
            gostjeIgralci[igralec].DodajGol();
        }

        public void DodajAsistencoDomaci(Igralec igralec)
        {
            domaciIgralci[igralec].DodajAsistenco();
        }

        public void DodajAsistencoGostje(Igralec igralec)
        {
            gostjeIgralci[igralec].DodajAsistenco();
        }

        public void DodajRumeniKartonDomaci(Igralec igralec)
        {
            domaciIgralci[igralec].dodajRumeniKarton();
        }

        public void DodajRumeniKartonGostje(Igralec igralec)
        {
            gostjeIgralci[igralec].dodajRumeniKarton();
        }

        public void DodajRdeciKartonDomaci(Igralec igralec)
        {
            domaciIgralci[igralec].dodajRdeciKarton();
        }

        public void DodajRdeciKartonGostje(Igralec igralec)
        {
            gostjeIgralci[igralec].dodajRdeciKarton();
        }

        public void DodajPrekrsekDomaci(Igralec igralec)
        {
            domaciIgralci[igralec].dodajPrekrsek();
        }

        public void DodajPrekrsekGostje(Igralec igralec)
        {
            gostjeIgralci[igralec].dodajPrekrsek();
        }
    }
}
