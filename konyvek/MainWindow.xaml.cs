using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace konyvek
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List <Konyv> Konyvek = new List <Konyv>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] adatok = File.ReadAllLines("kiadas.txt");

            for (int i = 0; i < adatok.Length; i++) {
                string[] vag= adatok[i].Split(";");
                //2020;1;ma;Szobonya Erzsébet: Sapho 1.;20000
                Konyvek.Add(new Konyv(int.Parse(vag[0]), int.Parse(vag[1]), vag[2], vag[3], int.Parse(vag[4]) ));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string szerzoBeker = szerzoNev.Text;
            int megszamolt = 0;

            foreach (Konyv konyv in Konyvek) {
                if (konyv.leiras.Contains(szerzoBeker)) {
                    megszamolt ++;
                }
            }

            if (megszamolt == 0)
            {
                masodikKiir.Text = "Nem adtak ki";
            }
            else
            {
                masodikKiir.Text = Convert.ToString(megszamolt)+" könyvkiadás";
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int legnagyobb = 0;
            int mennyiDb = 0;

            for (int i = 0; i < Konyvek.Count; i++){
                if (Konyvek[i].peldany > legnagyobb)
                {
                    legnagyobb = Konyvek[i].peldany;
                }
            };

            for (int i = 0; i < Konyvek.Count; i++) { 
                if (Konyvek[i].peldany == legnagyobb) {
                    mennyiDb++;
                }
            };

            harmadikKiir.Text = legnagyobb + ", előfordult " + mennyiDb + " alkalommal";

        }

        // külföldi = kf | 1. ami legalább 40000
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Konyv talalat = Konyvek[0];
           

            for (int i = 0; i < Konyvek.Count; i++) {
                if (Konyvek[i].eredet == "kf" && Konyvek[i].peldany >= 40000) {
                    talalat = Konyvek[i];
                    break;
                }              
            }

            negyedikKiir.Text = talalat.ev + "/" + talalat.negyedev + ". " + talalat.leiras;
        }
          

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //2020|21|22|23
            List<int> maKi = new List<int>() { 0, 0, 0, 0 };
            List<int> maPe = new List<int>() { 0, 0, 0, 0 };
            List<int> KfKi = new List<int>() { 0, 0, 0, 0 };
            List<int> KfPe = new List<int>() { 0, 0, 0, 0 };

            for (int i = 0; i < Konyvek.Count; i++)
            {
                // [0]
                if (Konyvek[i].ev == 2020)
                {
                    if (Konyvek[i].eredet == "ma")
                    {
                        maKi[0]++;
                        maPe[0]+= Konyvek[i].peldany;
                    }

                    else
                    {
                        KfKi[0]++;
                        KfPe[0] += Konyvek[i].peldany;
                    }
                }

                // [1]
                if (Konyvek[i].ev == 2021)
                {
                    if (Konyvek[i].eredet == "ma")
                    {
                        maKi[1]++;
                        maPe[1] += Konyvek[i].peldany;
                    }

                    else
                    {
                        KfKi[1]++;
                        KfPe[1] += Konyvek[i].peldany;
                    }
                }
                // [2]
                if (Konyvek[i].ev == 2022)
                {
                    if (Konyvek[i].eredet == "ma")
                    {
                        maKi[2]++;
                        maPe[2] += Konyvek[i].peldany;
                    }

                    else
                    {
                        KfKi[2]++;
                        KfPe[2] += Konyvek[i].peldany;
                    }
                }
                // [3]
                if (Konyvek[i].ev == 2023)
                {
                    if (Konyvek[i].eredet == "ma")
                    {
                        maKi[3]++;
                        maPe[3] += Konyvek[i].peldany;
                    }

                    else
                    {
                        KfKi[3]++;
                        KfPe[3] += Konyvek[i].peldany;
                    }
                }
            }

            List<string> evek = new List<string>();
            evek.Add("Év \t Magyar kiadás \t Magyar példányszám \t Külföldi kiadás \t Külföldi példányszám");
            for(int i = 0; i<4; i++)
            {
                evek.Add("202" + i + "\t" + "\t" + maKi[i] + "\t" + "\t" + maPe[i] + "\t" + "\t" + KfKi[i] +"\t" + "\t" + KfPe[i]);
            }

            adattabla.ItemsSource = evek;
        }

        
    }
}