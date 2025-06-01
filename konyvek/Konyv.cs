using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvek
{
    internal class Konyv
    {
        public int ev;
        public int negyedev;
        public string eredet;
        public string leiras;
        public int peldany;

        public Konyv(int ev, int negyedev, string eredet, string leiras, int peldany) {
            this.ev = ev;
            this.negyedev = negyedev;
            this.eredet = eredet;
            this.leiras = leiras;
            this.peldany = peldany;
        }
    }
}
