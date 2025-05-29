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

namespace SoftDrinksGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();

            List<Udito> Uditok = new List<Udito>();

            foreach (var item in File.ReadAllLines(@"..\..\..\src\softDrinks.txt").Skip(1))
            {
                Uditok.Add(new Udito(item));
            }


            Random random = new Random();
            var cukros = Uditok
                .Where(u => u.EdesitoNev == "cukor")  
                .GroupBy(u => u.Csomagolas) 
                .Select(g => new
                {
                    Csomagolas = g.Key,  
                    Udito = g.OrderBy(x => random.Next()).First()  
                })
                .ToList();


            var legolcsobb = Uditok.Where(x => x.GyumolcsTart == 0).MinBy(x => x.ArLiterenkent);

            NemGyumolcsos.Text = $"{legolcsobb.Nev} - {legolcsobb.ArLiterenkent} FT/L";

            var hanyfele = Uditok.GroupBy(x => x.Nev).Count();

            StreamWriter sw = new StreamWriter(path: @"..\..\..\src\all.txt");
            var f7 = Uditok.GroupBy(b => b.Nev).ToList();
            foreach ( var item in f7)
            {
                sw.WriteLine($"{item.Key} - {item.Count()}");
            }
            sw.Close();


            StreamWriter sw2 = new StreamWriter(path: @"..\..\..\src\sweetening.txt");
            var edesitos = Uditok.GroupBy(x => x.EdesitoNev);
            foreach ( var item in edesitos)
            {
                sw2.WriteLine($"{item.Key} - {item.Count()}");
            }
            


            



        }
    }
}