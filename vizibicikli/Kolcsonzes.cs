using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizibicikli
{
    internal class Kolcsonzes
    {
        public string Nev;
        public string Jarmu;
        public int OraKi;
        public int PercKi;
        public int OraBe;
        public int PercBe;
        public Kolcsonzes(string nev, string jarmu, int oraKi, int percKi, int oraBe, int percBe)
        {
            Nev = nev;
            Jarmu = jarmu;
            OraKi = oraKi;
            PercKi = percKi;
            OraBe = oraBe;
            PercBe = percBe;
        }

        public Kolcsonzes(string sor)
        {
            string[] vag = sor.Split(';');
            Nev = vag[0];
            Jarmu = vag[1];
            OraKi = int.Parse(vag[2]);
            PercKi = int.Parse(vag[3]);
            OraBe = int.Parse(vag[4]);
            PercBe = int.Parse(vag[5]);
        }

        public string idoKi()
        {
            return $"{OraKi}:{PercKi}:00";
        }

        public string idoBe()
        {
            return $"{OraBe}:{PercBe}:00";
        }

        public string idotartam()
        {
            return idoKi()+"-" + idoBe();
        }

    }
}
