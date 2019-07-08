using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Wagenpark wagenpark = new Wagenpark();
            Wagen lambo = new Wagen();

            wagenpark[0] = lambo;

            IKanVliegen vliegtuig = new Vliegtuig();
            vliegtuig.Vlieg(55);

            Vliegtuig vliegtuig2 = new Vliegtuig();
            vliegtuig2.Vlieg(55, 5000);

            Hond labrador = new Hond();

            labrador.GaNaarToilet();


            Dier eendiertje = new Dier();

            eendiertje.Beweeg();
        }
    }
}
