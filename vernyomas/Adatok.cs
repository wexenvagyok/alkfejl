using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vernyomas
{
    internal class Meres
    {
        public int napszam;
        public string napszak;
        public int szisztoles;
        public int diasztoles;
        public int pulzus;

        public Meres(int napszam, string napszak, int szisztoles, int diasztoles, int pulzus)
        {
            this.napszak = napszak;
            this.napszam = napszam;
            this.szisztoles = szisztoles;
            this.diasztoles = diasztoles;
            this.pulzus = pulzus;

        }
    }
}