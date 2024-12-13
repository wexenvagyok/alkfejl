using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanic
{
    internal class Utass
    {
        public int megallo;
        public string felszallas;
        public int azonosito;
        public string tipus;
        public string ervenyes;
        public int jegyDb;

        public Utass(string sor) 
        {
            string[] vag = sor.Split(' ');

            megallo = Convert.ToInt32(vag[0]);
            felszallas = vag[1];
            azonosito = Convert.ToInt32(vag[2]);
            tipus = vag[3];

            if (vag[4].Length == 0) {
                ervenyes = vag[4];
                jegyDb = -1;
            }
            else
            {
                ervenyes = "";
                jegyDb = Convert.ToInt32(vag[4]);
            }

        }
    }
}
