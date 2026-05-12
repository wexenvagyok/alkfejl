using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vercukor
{
    internal class Adatok
    {
        public int Nap { get; set; }
        public string Napszak { get; set; }
        public string Etkezes { get; set; }
        public double Ertek { get; set; }
        public Adatok(int nap, string napszak, string etkezes, double ertek)
        {
            Nap = nap;
            Napszak = napszak;
            Etkezes = etkezes;
            Ertek = ertek;
        }
    }
}
