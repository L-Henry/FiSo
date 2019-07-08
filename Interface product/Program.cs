using System;

namespace Interface_product
{
    class Program
    {
        static void Main(string[] args)
        {
            Winkel winkel = new Winkel();

            Koelkast koelkast = new Koelkast("Cool", "Subzero", 5000, "Wit");
            IProduct koelkastI = new Koelkast("Cool", "Subzero", 5000, "Grijs");

            winkel.VoegProductToe(koelkast);
            winkel.VoegProductToe(koelkastI);

            Gsm gsm = new Gsm("Nokia", "255", 100, true);
            IProduct gsmI = new Gsm("Nokia", "interface", 100, false);
            IProduct gsmI2 = new Gsm("Nokia", "interface", 100, true);

            winkel.VoegProductToe(gsm);
            winkel.VoegProductToe(gsmI);
            winkel.VoegProductToe(gsmI2);

            gsm.Bellen();
            
            winkel.ToonDetailsVanAlleProducten();

            


            Console.ReadLine();

        }
    }
}
