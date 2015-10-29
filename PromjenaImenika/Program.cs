
//using DrugiImenik
namespace PrviImenik
{
    class Program
    {
        static void Main(string[] args)
        {
            MojaKlasa mk1 = new MojaKlasa();
            mk1.Metoda1();
            //MojaKlasa mk2 = new MojaKlasa();
            DrugiImenik.MojaKlasa mk2 = new DrugiImenik.MojaKlasa();
            mk2.Metoda2();

            // dva pristupa, da se navede deklaracija i ime imenika ili navesti puni naziv klase
            //
        }
    }
}
