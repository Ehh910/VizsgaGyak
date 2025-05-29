namespace Kalapacsvetes
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
         List<Sportolo> Sportolok = new List<Sportolo>();

            foreach (var item in File.ReadAllLines(@"..\..\..\src\kalapacsvetes.txt").Skip(1))
            {
                Sportolok.Add(new Sportolo(item));
               
            }

            Console.WriteLine($"4. feladat: {Sportolok.Count}");

            var Magyarok = Sportolok.Where(x => x.OrszagKod == "HUN").Average(x => x.Eredmeny);
            Console.WriteLine($"5. feladat: {Math.Round(Magyarok ,1)}");

            Console.WriteLine(" 6. feladat: Kérem adjon meg egy évszámot!");
             var BekertEv = int.Parse( Console.ReadLine());
            var Evszamonkent = Sportolok.Where(x => x.Datum.Year.Equals(BekertEv)).ToList();
            if (Evszamonkent.Any())
            {
                Console.WriteLine($"{Evszamonkent.Count()} dobás került be ebben az évben.");
                Evszamonkent.ForEach(sportolo => Console.WriteLine($"- {sportolo.Nev}"));
            }
            else
            {
                Console.WriteLine("Egy dobás sem került be ebben az évben.");
            }

            var Orszagonkent = Sportolok
            .GroupBy(x => x.OrszagKod) 
            .Select(group => new { OrszagKod = group.Key, EredmenyekSzama = group.Count()}) 
            .ToList();

            Console.WriteLine("7. feladat: Statisztika:");
            foreach (var stat in Orszagonkent)
            {
                Console.WriteLine($"{stat.OrszagKod} - {stat.EredmenyekSzama} dobás");
            }

            var MagyarSportolok = Sportolok.Where(x => x.OrszagKod == "HUN").ToList();

            using (var sw = new StreamWriter(@"..\..\..\src\magyarok.txt", false, System.Text.Encoding.UTF8))
            {
                foreach (var sportolo in MagyarSportolok)
                {
                    sw.WriteLine($"{sportolo.Nev}, {sportolo.OrszagKod}, {sportolo.Datum:yyyy-MM-dd}, {sportolo.Eredmeny}");
                }
            }

        }
    }

}
    

