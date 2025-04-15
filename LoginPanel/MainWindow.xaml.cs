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

namespace LoginPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ListBox.ItemsSource = adatok; //nemjó

        }

        List<string> adatok = new List<string>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {/*
            string csere = textBox1.Text;
            
            textBox1.Text = textBox1.Text;

            passwordBox1.Password = csere;*/

            adatok.Add(textBox1.Text+":"+passwordBox1.Password);

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}