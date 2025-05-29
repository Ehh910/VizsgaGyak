namespace KajakKenuConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<KolcsonzesCONSOLE> Kolcsonzesek = new List<KolcsonzesCONSOLE>();
            foreach (var item in File.ReadAllLines(@"..\..\..\src\kolcsonzes.txt").Skip(1))
            {
                Kolcsonzesek.Add(new KolcsonzesCONSOLE(item));
            }

            ////feladat 4
            //var Osszkolcsonzes = Kolcsonzesek.Count();
            //Console.WriteLine($"Összesen ennyi kölcsönzés történt: {Osszkolcsonzes}");

            ////feladat 5
            //var bekertNev = Console.ReadLine();




            ////feladat 6
            //var osszesEmber = Kolcsonzesek.Count();
            //var hanyKulfoldi = Kolcsonzesek.Where(x => x.Nev.Contains(",")).ToList();
            //var hanyMagyar = Kolcsonzesek.Where(x => ! x.Nev.Contains(",")).ToList();
            //Console.WriteLine($" Ennyi külföldi bérlő van: {hanyKulfoldi.Count}");
            //Console.WriteLine($"Ennyi magyar bérlő van: {hanyMagyar.Count}");



            



            //feladat 3
            Console.WriteLine("Hány személyes hajót keresünk?");
            var hanyszemely = Console.ReadLine();

            var melyikazelso = Kolcsonzesek.Where(x => x.SzemelySzam == hanyszemely );

            //feladat 4

            var egyszemelyes = Kolcsonzesek.Where(x => x.SzemelySzam == 1)




        }
    }
}
