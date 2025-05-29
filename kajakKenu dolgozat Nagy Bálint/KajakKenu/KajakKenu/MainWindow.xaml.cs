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

namespace KajakKenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        { List<Kolcsonzes> Kolcsonzesek = new List<Kolcsonzes>();
            InitializeComponent();

            foreach (var item in File.ReadAllLines(@"..\..\..\src\kolcsonzes.txt").Skip(1)) 
            {
                Kolcsonzesek.Add(new Kolcsonzes(item));
            }

           DataGridhaha.ItemsSource = Kolcsonzesek;



        }
    }
}