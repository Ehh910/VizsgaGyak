using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsCLI
{
    internal class Apps
    {
        public string AppName { get; set; }
        public Category Category { get; set; }
        public ContentRating ContentRating { get; set; }
        public string Rating { get; set; }
        public int Reviews { get; set; }
        public string CurrentVer { get; set; }
        public int UpdateYear { get; set; }
        public int UpdateMonth { get; set; }

        public Apps(string appname, Category category,ContentRating contentRating, string rating, int reviews, string currentver, int updateyear, int updatemonth)
        {
            AppName = appname;
            ContentRating = contentRating;
            Rating = rating;
            Reviews = reviews;
            CurrentVer = currentver;
            UpdateYear = updateyear;
            UpdateMonth = updatemonth;
        }

        public static List<Apps> LoadFromCsv(string sor)
        {
           List<Apps> apps = new List<Apps>();

            string[] temp = File.ReadAllLines(sor);
            foreach (string t in temp.Skip(1))
            {
                string[] v = t.Split(';');

                string AppName = v[0];
                Category category = new Category(int.Parse(v[1]), v[2]);
                ContentRating contentRating = new ContentRating(int.Parse(v[3]), v[4]);
                string Rating = v[5];
                int reviews = int.Parse(v[6]);
                string currentver = v[7];
                int updateyear = int.Parse(v[8]);
                int updatemonth = int.Parse(v[9]);

                Apps appsok = new Apps(AppName, category, contentRating, Rating, reviews, currentver, updateyear, updatemonth);

                apps.Add(appsok);

            }
            return apps;
        }

        //public string ConvertToStars()
        //{
        //    if( Rating == 0)
        //    {
        //        return "-";
        //    }
        //    int starscount = (int)Math.Round(Rating);
        //    string stars = "";
        //    for (int i = 0; i < starscount; i++)
        //    {
        //        stars += "*";
        //    }
        //    return stars;
        //}

        public override string ToString()
        {
            return "";
        }



    }
}
