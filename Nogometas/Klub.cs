using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometas
{
    internal class Klub
    {
        string imeKluba;
        string mesto;
        string drzava;
        List<Igralec> igralci;
        Trener trener;
        Stadion stadion;

        public string ImeKluba { get => imeKluba; set => imeKluba = value; }
        public string Mesto { get => mesto; set => mesto = value; }
        public string Drzava { get => drzava; set => drzava = value; }

        public List<Igralec> Igralci { get => igralci; set => igralci = value; }
        public Trener Trener { get => trener; set => trener = value; }
        public Stadion Stadion { get => stadion; set => stadion = value; }

        public Klub(string imeKluba, string mesto, string drzava, List<Igralec> igralci, Trener trener, Stadion stadion)
        {
            this.imeKluba = imeKluba;
            this.mesto = mesto;
            this.drzava = drzava;
            this.igralci = igralci;
            this.trener = trener;
            this.stadion = stadion;
        }

        public Klub() { }
    }
}
