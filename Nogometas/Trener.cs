using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometas
{
    internal class Trener : Oseba
    {
        int steviloZmag;
        int steviloPorazov;
        int steviloNeodlocenih;
        
        public Trener(string ime, string priimek, DateTime datumRojstva, string drzavaRojstva, int steviloZmag, int steviloPorazov, int steviloNeodlocenih) : base(ime, priimek, datumRojstva, drzavaRojstva)
        {
            this.steviloZmag = steviloZmag;
            this.steviloPorazov = steviloPorazov;
            this.steviloNeodlocenih = steviloNeodlocenih;
        }

        public void DodajZmago()
        {
            steviloZmag++;
        }

        public void DodajPoraz()
        {
            steviloPorazov++;
        }

        public void DodajNeodloceno()
        {
            steviloNeodlocenih++;
        }
    }
}
