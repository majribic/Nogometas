using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometas
{
    internal class Stadion
    {
        string imeStadiona;
        string mesto;
        int kapaciteta;
        Klub klub;

        public Stadion(string imeStadiona, string mesto, int kapaciteta, Klub klub)
        {
            this.imeStadiona = imeStadiona;
            this.mesto = mesto;
            this.kapaciteta = kapaciteta;
            this.klub = klub;
        }
    }
}
