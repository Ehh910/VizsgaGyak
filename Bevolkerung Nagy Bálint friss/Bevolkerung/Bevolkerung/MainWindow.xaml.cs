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

namespace Bevolkerung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Ember> Emberek;
        public MainWindow()
        {
            InitializeComponent();
            Emberek = new List<Ember>();
            foreach(var item in File.ReadAllLines(@"..\..\..\src\bevölkerung.txt").Skip(1))
            {
                Emberek.Add(new Ember(item));
            }

            Minden.ItemsSource = Emberek;

        }
    }
}