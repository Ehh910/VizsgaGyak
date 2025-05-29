using Orai0116.img;
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

namespace Orai0116
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Hajo> hajok = new List<Hajo>();
        public MainWindow()
        {
            InitializeComponent();

            foreach(var item in File.ReadAllLines(@"..\..\..\src\hajo.txt"))
            {
                hajok.Add(new Hajo(item));
            }

            HajoValaszt.ItemsSource = hajok.Select(x => x.Nev);



            //feladat 4
            var kishajok = hajok
               .Where(a => a.MaxUtas < 6)
               .Select(a => new
               {
                   KisHajoNev = a.Nev,
                   KisHajoAr = a.NapiBerlesiDij
               });
            StreamWriter sw = new StreamWriter(path: @"..\..\..\src\kishajok.txt");
            foreach (var item in kishajok)
            {
                sw.WriteLine($"{item.KisHajoNev}, {item.KisHajoAr}");
            }
            sw.Close();
        }
        //feladat 5
        private void SzamolasBtn_Click(object sender, RoutedEventArgs e)
        {
            int napokSzama;
            if (int.TryParse(NapokSzama.Text, out napokSzama))
            {
                var osszesKoltseg = hajok.Sum(a => a.KiszamoltErtek(napokSzama));
                HanyNapiKoltseg.Content = $"{napokSzama} napi költség: {osszesKoltseg}";
            }
        }


        //feladat 6
        private void KeresesBtn_Click(object sender, RoutedEventArgs e)
        {
            int keresettUtasSzam;
            if (int.TryParse(Hanyutas.Text, out keresettUtasSzam))
            {
                var megfeleloHajo = hajok
                    .Where(a => a.MaxUtas >= keresettUtasSzam)
                    .Select(a => new
                    {
                        a.Nev,
                        a.MaxUtas,
                        a.NapiBerlesiDij
                    })
                    .FirstOrDefault();

                if (megfeleloHajo != null)
                {
                    AjanlottHajoLbl.Content = $"{megfeleloHajo.Nev}";
                    HajoInformacio.Content = $"Max utas: {megfeleloHajo.MaxUtas},\nNapi bérleti díj: {megfeleloHajo.NapiBerlesiDij}";
                }
                else
                {
                    AjanlottHajoLbl.Content = "";
                    HajoInformacio.Content = "Sajnos nem tudunk hajót ajánlani";
                }
            }
            else
            {
                AjanlottHajoLbl.Content = "";
                HajoInformacio.Content = "Kérjük, adja meg, hány főre szeretne hajót bérelni!";
            }
        }


    }
}