namespace AutoKonzol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Auto> Autok = new List<Auto>();

            foreach( var item in Auto.LoadFromCsv(@"..\..\..\src\carsData.csv"))
            {
                Autok.Add(item);
            }

            var RollsRoyceBatya = Autok.Where(x => x.Gyarto.GyartoNev == "Rolls-Royce" && x.Karosszeria.KarosszeriaNev == "Sedan" && x.Hengerek == 8).ToList().Count();

            Console.WriteLine($"6. feladat - 8 hengeres, Rolls-Royce sedánok száma az adott időszakban: {RollsRoyceBatya}db");

            var Legdragabb = Autok.MaxBy(x => x.VetelAr);

            Console.WriteLine($"{Legdragabb.Azonosito} Autó: \n{Legdragabb}");

            //var Forma1ReHajazo = new List<string> { "Aston Martin", "Ferrari", "McLaren", "Mercedes-Benz", "Porsche" };

            var Nyolcadik = Autok.Where(x => x.Gyarto.GyartoNev == "Aston Martin" || x.Gyarto.GyartoNev == "Ferrari" || x.Gyarto.GyartoNev == "McLaren" || x.Gyarto.GyartoNev == "Mercedes-Benz" || x.Gyarto.GyartoNev == "Porsche");

            Console.WriteLine("8. feladat - Adatok fájlba írása");

            using (StreamWriter writer = new StreamWriter(@"..\..\..\src\forma-1.txt"))
            {
                foreach (var auto in Nyolcadik)
                {
                    writer.WriteLine($"{auto.Azonosito}; {auto.Gyarto.GyartoNev}; {auto.Modell}; {auto.Evjarat}, {auto.Kilometer}");
                }
            }

        }
    }
}
