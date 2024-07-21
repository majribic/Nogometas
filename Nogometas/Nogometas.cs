using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometas
{
    public class Nogometas : Oseba
    {
        int stevilkaDresa;
        string pozicija;
        int steviloGolov;
        int steviloAsistenc;
        int steviloRumenihKartonov;
        int steviloRdecihKartonov;

        public int StevilkaDresa { get => stevilkaDresa; set => stevilkaDresa = value; }
        public string Pozicija { get => pozicija; set => pozicija = value; }
        public int SteviloGolov { get => steviloGolov; set => steviloGolov = value; }
        public int SteviloAsistenc { get => steviloAsistenc; set => steviloAsistenc = value; }
        public int SteviloRumenihKartonov { get => steviloRumenihKartonov; set => steviloRumenihKartonov = value; }
        public int SteviloRdecihKartonov { get => steviloRdecihKartonov; set => steviloRdecihKartonov = value; }

        public Nogometas():base() { }
        public Nogometas(int stevilkaDresa, string pozicija, int steviloGolov, int steviloAsistenc, int steviloRumenihKartonov, int steviloRdecihKartonov): base( ime, priimek, datumRojstva, drzavaRojstva)
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
