using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    public class Ad
    {
        public int Id { get; set; }
        public int Rooms { get; set; }
        public string LatLong { get; set; }
        //public string Szelessegi => LatLong.Split(',')[0];
        //public string Hosszusagi => LatLong.Split(",")[1];
        public int Floors { get; set; }
        public int Area { get; set; }
        public string Description { get; set; }
        public bool FreeOfCharge { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreateAt { get; set; }
        public Seller Seller { get; set; }
        public Category Category { get; set; }

        public Ad(int id, int rooms,string latlong,int floors, int area, string description, bool freeofcharge, string imageurl,DateTime createat, Seller seller, Category category)
        {
            Id = id;
            Rooms = rooms;
            LatLong = latlong;
            Floors = floors;
            Area = area;
            Description = description;
            FreeOfCharge = freeofcharge;
            ImageUrl = imageurl;
            Seller = seller;
            Category = category;

        }

        public static List<Ad> LoadFromCsv(string path)
        {
            List<Ad> Ads = new List<Ad>();

            string[] temp = File.ReadAllLines(path);

            foreach (string t in temp.Skip(1))
            {
                string[] v = t.Split(';');

                int Id = int.Parse(v[0]);
                int Rooms = int.Parse(v[1]);
                string LatLong = v[2];
                int Floors = int.Parse(v[3]);
                int Area = int.Parse(v[4]);
                string Description = v[5];
                bool FreeOfCharge = v[6] == "1" ? true : false;
                string ImageUrl = v[7];
                DateTime CreateAt = DateTime.Parse(v[8]);
                Seller Seller = new Seller(int.Parse(v[9]), v[10], v[11]);
                Category Category = new Category(int.Parse(v[12]), v[13]);

                Ad ads = new Ad(Id, Rooms, LatLong, Floors, Area, Description, FreeOfCharge, ImageUrl, CreateAt, Seller, Category);

                Ads.Add(ads);
                
            }
            return Ads;
        }


    }

}
