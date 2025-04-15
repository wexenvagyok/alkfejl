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

namespace Eltunes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int szamlalo = 0;
        private void Eltunes_Click(object sender, RoutedEventArgs e)
        {
            if (szamlalo % 2 == 0)
            {
                nicetrykocsog.Visibility = Visibility.Hidden;
                
            }
            else
            {
                nicetrykocsog.Visibility = Visibility.Visible;
            }
            szamlalo++;
        }
    }
}