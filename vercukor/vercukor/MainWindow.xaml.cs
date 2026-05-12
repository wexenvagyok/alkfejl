using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace vercukor
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int nap = Convert.ToInt32(napsorszam.Text);

            double ertek = Convert.ToDouble(mertErtek.Text);

            if (nap < 1 || nap > 30)
            {
                visszajelzes.Text = "1-30 közötti lehet a nap";
                visszajelzes.Foreground = Brushes.Red;
                return;
            }

            if (ertek < 0 || ertek > 40)
            {
                visszajelzes.Text = "0-40 közötti lehet az érték";
                visszajelzes.Foreground = Brushes.Red;
                return;
            }

            if (napszak.SelectedItem == null || elottvagyutan.SelectedItem == null)
            {
                visszajelzes.Text = "Minden mezőt tölts ki";
                visszajelzes.Foreground = Brushes.Red;
                return;
            }

            string etkezes = ((ComboBoxItem)elottvagyutan.SelectedItem).Content.ToString();

            if (etkezes == "Étkezés előtt")
            {
                if (ertek >= 3.9 && ertek <= 5.6) //IDE MAGAS VAGY ALACSONY
                {
                    magasVagyAlacsony.Text = "Normális vércukorszint";
                    magasVagyAlacsony.Foreground = Brushes.Green;
                }
                else
                {
                    magasVagyAlacsony.Text = "Nem normális vércukorszint";
                    magasVagyAlacsony.Foreground = Brushes.Red;
                }
            }
            else
            {
                if (ertek < 7.8)
                {
                    magasVagyAlacsony.Text = "Normális vércukorszint";
                    magasVagyAlacsony.Foreground = Brushes.Green;
                }   
                else
                {
                    magasVagyAlacsony.Text = "Nem normális vércukorszint";
                    magasVagyAlacsony.Foreground = Brushes.Red;
                }
            }
        }
    }
}