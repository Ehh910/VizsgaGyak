using System.ComponentModel;

namespace RealEstate
{
    internal class Program
    {      
        static void Main(string[] args)
        {
             List<Ad> Ads = new List<Ad>();
            //Ads = Ad.LoadFromCsv(@"..\..\..\src\realestates.csv");

            //foreach (Ad k in Ads)
            //{
            //    Console.WriteLine(k.ToString());
            //}
            foreach(var item in Ad.LoadFromCsv(@"..\..\..\src\realestates.csv"))
            {
                Ads.Add(item);
            }
            
            var elsofeladat = Ads.Where(x => x.Floors == 0).Average(x => x.Area);
            Console.WriteLine($" A földszinti ingatlanok átlagos alapterülete: {Math.Round(elsofeladat, 2)}");

            


        }
    }
}
    