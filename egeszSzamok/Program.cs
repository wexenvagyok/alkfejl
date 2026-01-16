namespace egeszSzamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             olyan class ami egész számokat tárol egy listában, eg tömböt átadva, listában tarolja, az operatoroknal az objektumokat összeadjuk akkor a
            listakat fuzze össze, ha szamot akkor fuzze hozza a lisahoz azt a szamot, ha szamhoz adjuk hozza akkor a lista összeget adja a szamhoz, kivonás, objektumból
            másik objektum, a masodik objektum szamainak eltavolitasa az elso listából, ha tobb van az elsoben akkor csak 1db ot vegyen ki, ha szamot vonunk ki akkor azt a szamot
            törölje ki az elso olyan szamot objektumból, ha szambol akkor a lista összeget, szorzas, ha két objektumot összeszorzunk, akkor a lista elemeit szorozza össze, ha valamelyik
            nem egyforma hosszu akkor ott ne legyen elem, ha szammal szorozzuk akkor a lista minden elemet megszorozzuk azzal a szammal, ha szamot szorzunk akkor az összegel
            (lista elemeinek összegével) szorozzuk meg
            */

            Szamok sz1 = new Szamok(new int[] { 1, 2, 3, 4, 5 });
            Szamok sz2 = new Szamok(new int[] { 2, 3, 6, 8});

            Console.WriteLine(sz1 + sz2);
            Console.WriteLine(sz1);
            Console.WriteLine(sz1 + 200);
            Console.WriteLine(1 + sz1);

        }
    }
}
