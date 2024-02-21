using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SzyfrHomofonicznyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SzyfrHomofoniczny szyfrHomofoniczny = new SzyfrHomofoniczny();

        public MainWindow()
        {
            InitializeComponent();
        }

        


        public class SzyfrHomofoniczny
        {
            private Dictionary<char, List<string>> SzyfrDictionary = new Dictionary<char, List<string>>
        {
           { 'a', new List<string> { "294", "183", "612", "409", "287", "504", "526", "150", "803" } },
                    { 'ą', new List<string> { "952" } },
                    { 'b', new List<string> { "410" } },
                    { 'c', new List<string> { "591", "613", "204", "950" } },
                    { 'ć', new List<string> { "726" } },
                    { 'd', new List<string> { "319", "982", "687" } },
                    { 'e', new List<string> { "305", "946", "418", "752", "890", "167", "209", "478" } },
                    { 'ę', new List<string> { "614" } },
                    { 'f', new List<string> { "871" } },
                    { 'g', new List<string> { "395" } },
                    { 'h', new List<string> { "137" } },
                    { 'i', new List<string> { "524", "318", "761", "405", "604", "704", "290", "158" } },
                    { 'j', new List<string> { "491", "386" } },
                    { 'k', new List<string> { "618", "747", "420", "376" } },
                    { 'l', new List<string> { "125", "306" } },
                    { 'ł', new List<string> { "615", "490" } },
                    { 'm', new List<string> { "281", "673", "421", "492" } },
                    { 'n', new List<string> { "360", "985", "472", "156", "829" } },
                    { 'ń', new List<string> { "517" } },
                    { 'o', new List<string> { "259", "364", "197", "842", "536", "482", "670", "301" } },
                    { 'ó', new List<string> { "648" } },
                    { 'p', new List<string> { "471", "516", "180" } },
                    { 'q', new List<string> { "989" } },
                    { 'r', new List<string> { "389", "762", "415", "690", "134" } },
                    { 's', new List<string> { "206", "841", "590", "743" } },
                    { 'ś', new List<string> { "214" } },
                    { 't', new List<string> { "475", "981", "683", "240" } },
                    { 'u', new List<string> { "610", "378", "429" } },
                    { 'v', new List<string> { "915" } },
                    { 'w', new List<string> { "697", "830", "241", "561", "348" } },
                    { 'x', new List<string> { "480" } },
                    { 'y', new List<string> { "267", "589", "143", "961" } },
                    { 'z', new List<string> { "782", "645", "192", "457", "630", "843" } },
                    { 'ź', new List<string> { "404" } },
                    { 'ż', new List<string> { "962" } },
        };

            private Random random = new Random();

            private Dictionary<string, char> OdwrotneMapowanie(Dictionary<char, List<string>> oryginalneMapowanie)
            {
                var odwrotneMapowanie = new Dictionary<string, char>();
                foreach (var wpis in oryginalneMapowanie)
                {
                    foreach (var kod in wpis.Value)
                    {
                        odwrotneMapowanie[kod] = wpis.Key;
                    }
                }
                return odwrotneMapowanie;
            }

            public string Deszyfruj(string input)
            {
                var odwrotneMapowanie = OdwrotneMapowanie(SzyfrDictionary);
                var sb = new StringBuilder();
                var kod = new StringBuilder();
                var kody = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 

                foreach (var kodHomofoniczny in kody)
                {
                    if (odwrotneMapowanie.TryGetValue(kodHomofoniczny, out char litera))
                    {
                        sb.Append(litera);
                    }
                    else
                    {
                        sb.Append("?"); 
                    }
                }

                return sb.ToString();
            }


            public string Szyfruj(string input)
            {
                StringBuilder sb = new StringBuilder();

                foreach (char c in input.ToLower())
                {
                    if (SzyfrDictionary.ContainsKey(c))
                    {
                        var list = SzyfrDictionary[c];
                        var homofon = list[random.Next(list.Count)];
                        sb.Append(homofon);
                    }
                    else
                    {
                        sb.Append(c); 
                    }
                }

                return sb.ToString();
            }

        }

       

        private void encryptButton_Click(object sender, RoutedEventArgs e)
        {
            string input = inputTextBox.Text;
            string encrypted = szyfrHomofoniczny.Szyfruj(input);
            outputTextBox.Text = encrypted;
        }

        private void decryptButton_Click(object sender, RoutedEventArgs e)
        {
            string input = inputTextBox.Text;
            string decrypted = szyfrHomofoniczny.Deszyfruj(input);
            outputTextBox.Text = decrypted;
        }

       


        private void inputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void outputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
