using System.Text;
using System.Windows;
using MySql.Data.MySqlClient;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RealEstate;

namespace RealEstateGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Ad> Ads;
        public MainWindow()
        {
            InitializeComponent();

         Ads = new List<Ad>();

           
        }

        private void HirdetesBetoltesBtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in Ads)
            {
                NevSor.Items.Add(item.Seller.Name);
            }

            string connectionString = "server=localhost;user=root;password=;database=ingatlan";

            List<Ad> NewAds = new List<Ad>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string AdsQuery = @"SELECT realestates.id, realestates.rooms, realestates.latlong, realestates.floors, realestates.area, realestates.description, realestates.freeOfCharge, realestates.imageUrl, realestates.createAt, sellers.id, sellers.name, sellers.phone, categories.id , categories.name FROM realestates INNER JOIN categories ON realestates.categoryId = categories.id INNER JOIN sellers ON realestates.sellerId = sellers.id;";
                using (MySqlCommand command = new MySqlCommand(AdsQuery, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //int id = reader.GetInt32(0);
                        //string nev = reader.GetString(1);
                        //bool kan = reader.GetBoolean(2);
                        //Fajta fajta = new Fajta(reader.GetInt32(3), reader.GetString(4));
                        //Gazda gazda = new Gazda(reader.GetInt32(5), reader.GetString(6), reader.GetString(7));
                        //int kor = reader.GetInt32(8);
                        //DateTime chipDatum = reader.GetDateTime(9);
                        //string kepUrl = reader.GetString(10);
                        int id = reader.GetInt32(0);
                        int rooms = reader.GetInt32(1);
                        string latlong = reader.GetString(2);
                        int floors = reader.GetInt32(3);
                        int area = reader.GetInt32(4);
                        string description = reader.IsDBNull(5) ? "Üres" :  reader.GetString(5);
                        bool freeofcharge = reader.GetBoolean(6);
                        string imageurl = reader.GetString(7);
                        DateTime createat = reader.GetDateTime(8);
                        Seller seller = new Seller(reader.GetInt32(9), reader.GetString(10), reader.GetString(11));
                        Category category = new Category(reader.GetInt32(12), reader.GetString(13));

                        var adsek = new Ad(id, rooms, latlong, floors, area, description, freeofcharge, imageurl, createat, seller, category);
                        Ads.Add(adsek);



                    }
                }
                connection.Close();
            }
        }

        private void NevSor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var valasztott = Ads.Where(x => Ads.IndexOf(x) == NevSor.SelectedIndex).ToList();
            foreach (var item in valasztott)
            {
                EladoNeveLbl.Content = item.Seller.Name;
                TelefonSzamLbl.Content = item.Seller.Phone;
                HirdetesSzamLbl.Content = item.Id;
            }
        }
    }
}