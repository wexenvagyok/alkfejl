using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_gyakorlas_12_11
{
    internal class Penztarca
    {
        int penz;
        public string szin;
        public int Penz
            {
            get
            {
                return penz;
            }

            set
            {
                penz = value;
            }
        }

        public Penztarca(int penz)
        {
            Penz = penz;
        }

        public Penztarca(int penz, string szin)
        {
            Penz = penz;
            this.szin = szin;
        }

        public override string ToString()
        {
            return $"{szin} buksza, benne {penz} Forint.";
        }
    }
}
