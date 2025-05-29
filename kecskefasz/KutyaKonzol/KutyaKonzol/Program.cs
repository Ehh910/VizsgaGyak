namespace KutyaKonzol
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Kutya> Kutyak = new List<Kutya>();
            foreach (var item in File.ReadAllLines(@"..\..\..\src\adatok.csv").Skip(1))
            {
                Kutyak.Add(new Kutya(item));
            }


        }
    }
}
