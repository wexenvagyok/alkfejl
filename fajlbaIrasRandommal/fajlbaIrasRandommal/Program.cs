namespace fajlbaIrasRandommal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            List <string> szamok = new List<string>();
            string szamjegy = "";
            File.WriteAllText("szamok.txt", "");

            for (int i = 0; i < 12000; i++)
            {
                szamjegy = "";
                for (int j = 0; j < 22; j++)
                {
                    szamjegy += rnd.Next(0, 10).ToString();
                }
                szamok.Add(szamjegy);
                File.AppendAllText("szamok.txt", szamjegy + "\n");

                Console.WriteLine(szamjegy.ToString() + "\n");
            }
            
            
        }
    }
}
