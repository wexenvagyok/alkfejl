using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latintanc
{
    public class Tanc
    {
        public string TancNev { get; }
        public string Lany { get; }
        public string Fiu { get; }

        public Tanc(string tancNev, string lany, string fiu)
        {
            TancNev = tancNev;
            Lany = lany;
            Fiu = fiu;
        }
    }
}

