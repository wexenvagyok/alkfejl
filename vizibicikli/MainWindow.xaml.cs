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

namespace vizibicikli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Betolt();
        }

        List<Kolcsonzes> kolcsonzesek = new List<Kolcsonzes>();

        public void Betolt()
        {
            string[] sorok = File.ReadAllLines("kolcsonzesek.txt");

            foreach (string sor in sorok.Skip(1))
            {
                kolcsonzesek.Add(new Kolcsonzes(sor));
            }

            //MessageBox.Show($"{kolcsonzesek.Count}");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            eredmeny2.Content = $"{kolcsonzesek.Count}";
        }

        private void bekertNev_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var szures = kolcsonzesek
                .Where(x => x.Nev == bekertNev.Text)
                .Select(x => x.idotartam())
                .ToList();

            if (szures.Count == 0)
            {
                hiba6.Content = "Nincs ilyen nevű!";
            }
            else
            {
                hiba6.Content = "";
                eredmeny6.ItemsSource = szures;

            }
        }
    }
}