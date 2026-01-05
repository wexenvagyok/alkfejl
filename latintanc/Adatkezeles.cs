using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using latintanc;

namespace latintanc
{
    public static class Adatkezeles
    {
        // Beolvasás a "tancrend.txt" fájlból
        public static List<Tanc> Beolvas()
        {
            var sorok = File.ReadAllLines("tancrend.txt")
                             .Where(line => !string.IsNullOrWhiteSpace(line)) 
                             .ToList();

            var tancok = new List<Tanc>();

            for (int i = 0; i < sorok.Count; i += 3)
            {
                if (i + 2 < sorok.Count)
                {
                    var tancNev = sorok[i];
                    var lanyNev = sorok[i + 1];
                    var fiuNev = sorok[i + 2];
                    tancok.Add(new Tanc(tancNev, lanyNev, fiuNev));
                }
            }

            return tancok;
        }

        public static int SambaParokSzama(List<Tanc> adatok)
        {
            return adatok.Count(a => a.TancNev.ToLower() == "samba");
        }

        public static List<string> VilmaTancai(List<Tanc> adatok)
        {
            return adatok
                .Where(a => a.Lany == "Vilma")
                .Select(a => a.TancNev)
                .ToList();
        }
    }
}
