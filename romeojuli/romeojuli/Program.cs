using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace RegEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string forras = File.ReadAllText("romeoesjulia.txt");

            Regex rg = new Regex(@"[A-ZÖÜÓŐÚÉÁŰÍ-]{2,} [A-ZÖÜÓŐÚÉÁŰÍ-]{2,}|[A-ZÖÜÓŐÚÉÁŰÍ-]{2,}\b");
            var eredmeny = rg.Matches(forras);
            
            Regex romeonev = new Regex(@"ROMEO", RegexOptions.IgnoreCase);
            //Console.WriteLine(eredmeny.Count);

            foreach (Match item in eredmeny)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine();
            Console.WriteLine("Rómeó ennyiszer");
            Console.WriteLine(romeonev.Matches(forras).Count +" darab");
            Console.WriteLine();

            Regex szam = new Regex(@"[0-9]{4}");
            var szamok = szam.Matches(forras);
            Console.WriteLine(szamok.Count);

            Regex elsoOrElsoSzo = new Regex(@"ELSŐ ŐR\t\w[A-ZÍÖÜÓŐÚÉÁŰ]+", RegexOptions.IgnoreCase);

            var elsoOrSzavai = elsoOrElsoSzo.Matches(forras);

            foreach (Match item in elsoOrSzavai)
            {
                Console.WriteLine(item.Value);
            }
            
        }
    }
}