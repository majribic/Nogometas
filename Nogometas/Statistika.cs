using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nogometas
{
    internal class Statistika
    {
        int steviloGolov;
        int steviloAsistenc;
        int minutaza;
        int steviloRumenihKartonov;
        int steviloRdecihKartonov;
        int prekrski;

        public Statistika(int steviloGolov, int steviloAsistenc, int minutaza, int steviloRumenihKartonov, int steviloRdecihKartonov, int prekrski)
        {
            this.steviloGolov = steviloGolov;
            this.steviloAsistenc = steviloAsistenc;
            this.minutaza = minutaza;
            this.steviloRumenihKartonov = steviloRumenihKartonov;
            this.steviloRdecihKartonov = steviloRdecihKartonov;
            this.prekrski = prekrski;
        }

        public void DodajGol()
        {
            steviloGolov++;
        }

        public void DodajAsistenco()
        {
            steviloAsistenc++;
        }

        public void dodajRumeniKarton()
        {
            steviloRumenihKartonov++;
        }

        public void dodajRdeciKarton()
        {
            steviloRdecihKartonov++;
        }
        public void dodajPrekrsek()
        {
            prekrski++;
        }
    }
}
