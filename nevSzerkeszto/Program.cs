using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace nevSzerkeszto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vezeteknev = File.ReadAllLines("vezeteknev.txt");
            string[] utonevF = File.ReadAllLines("utonevF.txt");
            string[] utonevN = File.ReadAllLines("utonevN.txt");

            string[] vnevek = vezeteknev[0].Split(" ");
            string[] unevekF = utonevF[0].Split(" ");
            string[] unevekN = utonevN[0].Split(" ");

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                string vezetek = vnevek[rnd.Next(vnevek.Length)];
                string utonev;
                string utonevMasodik;
                if (rnd.Next(2) == 0)
                {
                    utonev = unevekF[rnd.Next(unevekF.Length)];
                    utonevMasodik = unevekF[rnd.Next(unevekF.Length)];
                }
                else
                {
                    utonev = unevekN[rnd.Next(unevekN.Length)];
                    utonevMasodik = unevekN[rnd.Next(unevekN.Length)];
                }
                Console.WriteLine($"{vezetek} {utonev} {utonevMasodik}");
            }
        }
    }
}
