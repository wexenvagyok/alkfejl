namespace kraterek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("felszin_tvesszo.txt");

            List<Krater> kraterek = new List<Krater>();

            for (int i = 0; i < sorok.Length; i++)
            {
                kraterek.Add(new Krater(sorok[i]));
            }

            Console.WriteLine("2. feladat\n A kráterek száma: {0}",kraterek.Count);
            Console.WriteLine("3. feladat");
            Console.WriteLine("Kérem egy kráter nevét!!!!!!!!!!!:   ");
            string nev = Console.ReadLine();

            //segédváltozó
            string szoveg = "Nincs ilyen kráter";

            for (int i = 0;i < kraterek.Count;i++)
            {
                if (kraterek[i].nev == nev)
                {
                    szoveg = kraterek[i].ToString();
                }
            }
            Console.WriteLine(szoveg);
        }
    }
}
