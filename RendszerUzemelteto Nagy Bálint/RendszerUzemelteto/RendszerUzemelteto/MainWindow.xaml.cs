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

namespace RendszerUzemelteto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   List<Vizsgazo> Vizsgazok = new List<Vizsgazo>();
        public MainWindow()
        {
            InitializeComponent();

            foreach(var item in File.ReadAllLines(@"..\..\..\src\adatok.txt"))
            {
                Vizsgazok.Add(new Vizsgazo(item));
            }
            HanyEmber.Content = $"{Vizsgazok.Count()} vizsázó adatait beolvastuk";
            vizsgazoNevek.ItemsSource = Vizsgazok.Select(x => x.Nev);

        }

        private void SikeresesVizsgaBtn_Click(object sender, RoutedEventArgs e)
        {
            int successfulCount = Vizsgazok.Count(v => v.Erdemjegy() != "elégtelen");
            SIkeresVizsgaLbl.Content = $"{successfulCount} fő";
        }

        private void EredmenyIrasTxt_Click(object sender, RoutedEventArgs e)
        {
            var atmentek = Vizsgazok.Where(x => x.Erdemjegy() != "elégtelen").ToList();
            StreamWriter sw = new StreamWriter(@"..\..\..\src\vizsgaredmenyek.txt");
               foreach(var item in atmentek) 
            {
                sw.WriteLine($"{item.Nev}, {item.Vegeredmeny()}, {item.Erdemjegy()}");
            }
               sw.Close();
                      
        }

        private void KeresettTanulo_TextChanged(object sender, TextChangedEventArgs e)
        {
            foreach (var item in Vizsgazok)
            {
                 List<double> ErdemjegyLista = new List<double>();
                ErdemjegyLista.Add(item.ItHalozat);
                ErdemjegyLista.Add(item.Progamozas);
                ErdemjegyLista.Add(item.HalozatA);
                ErdemjegyLista.Add(item.HalozatB);
                ErdemjegyLista.Add(item.HalozatC);
                ErdemjegyLista.Add(item.HalozatD);
                ErdemjegyLista.Add(item.SzobeliAngol);
                ErdemjegyLista.Add(item.SzobeliIT);

                if( item.Nev == KeresettTanulo.Text)
                {
                    LeggyengebbErdemyeLb.Content = $"Legjobb erdeménye: {ErdemjegyLista.Min()}";
                    LegjobbEredmenyeLbl.Content = $"Leggyengébb eredménye: {ErdemjegyLista.Max()}";
                    SikeresVizsgatTettELbl.Content = $"A vizsgázó érdemjegye: { item.Erdemjegy()}";

                }
            }
        }
    }
}