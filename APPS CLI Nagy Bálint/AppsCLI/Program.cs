namespace AppsCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Apps> Appsok = new List<Apps>();

            foreach (var item in Apps.LoadFromCsv(@"..\..\..\src\apps.csv"))
            {
                Appsok.Add(item);
            }
            var muki = Appsok.Where(x => x.UpdateYear == 2018);

            Console.WriteLine(muki);
        }
    }
}
