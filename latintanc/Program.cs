using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Tanciskola
{
    static void Main()
    {
        var adatok =
            File.ReadAllLines("tancrend.txt")
                .Chunk(3)
                .Select(chunk => new Tanc(chunk[0], chunk[1], chunk[2]))
                .ToList();

        // 2. feladat
        Console.WriteLine("2. feladat:");
        if (adatok.Any())
        {
            Console.WriteLine($"Az első tánc: {adatok.First().TancNev}");
            Console.WriteLine($"Az utolsó tánc: {adatok.Last().TancNev}");
        }
        else
        {
            Console.WriteLine("Nincsenek adatok a fájlban.");
        }

        // 3. feladat
        Console.WriteLine("3. feladat:");
        int sambaParokSzama = Adatkezeles.SambaParokSzama(adatok);
        Console.WriteLine($"A sambát {sambaParokSzama} pár mutatta be.");

        // 4. feladat
        Console.WriteLine("Vilma a következő táncokban szerepelt:");
        var vilmaTancai = Adatkezeles.VilmaTancai(adatok);
        foreach (var tanc in vilmaTancai)
        {
            Console.WriteLine(tanc);
        }
    }
}

// Tánc osztály a tánc adatainak tárolására
public class Tanc
{
    public string TancNev { get; }
    public string Tancos { get; }
    public string Pár { get; }

    public Tanc(string tancNev, string tancos, string par)
    {
        TancNev = tancNev;
        Tancos = tancos;
        Pár = par;
    }
}

// Az Adatkezeles osztály példányosítása
public static class Adatkezeles
{
    // A sambát táncoló párok számának meghatározása
    public static int SambaParokSzama(List<Tanc> tancok)
    {
        return tancok.Count(t => t.TancNev == "Samba");
    }

    // Vilma
    public static List<string> VilmaTancai(List<Tanc> tancok)
    {
        return tancok
            .Where(t => t.Tancos == "Vilma")
            .Select(t => t.TancNev)
            .ToList();
    }
}
