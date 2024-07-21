using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometas
{
    public class Igralec : Oseba
    {
        int stevilkaDresa;
        string pozicija;
        int steviloGolov;
        int steviloAsistenc;
        int steviloRumenihKartonov;
        int steviloRdecihKartonov;

        public Igralec(int stevilkaDresa, string pozicija, int steviloGolov, int steviloAsistenc, int steviloRumenihKartonov, int steviloRdecihKartonov) : base( ime, priimek, datumRojstva, drzavaRojstva)
        {
            this.stevilkaDresa = stevilkaDresa;
            this.pozicija = pozicija;
            this.steviloGolov = steviloGolov;
            this.steviloAsistenc = steviloAsistenc;
            this.steviloRumenihKartonov = steviloRumenihKartonov;
            this.steviloRdecihKartonov = steviloRdecihKartonov;
        }
    }
}
