using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometas
{
    public class Oseba
    {
        public string ime;
        public string priimek;
        public DateTime datumRojstva;
        public string drzavaRojstva;

        public Oseba(string ime, string priimek, DateTime datumRojstva, string drzavaRojstva)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.datumRojstva = datumRojstva;
            this.drzavaRojstva = drzavaRojstva;
        }
    }
}
