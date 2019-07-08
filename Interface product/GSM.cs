using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_product
{
    class Gsm : IProduct
    {

        

        public string Merknaam { get; set;  }
        public string Modelnaam { get; set; }
        public decimal Prijs { get; set; }
        public bool Waterproof { get; set; }

        public Gsm(string merkNaam, string modelNaam, decimal prijs, bool waterproof = false)
        {
            Merknaam = merkNaam;
            Modelnaam = modelNaam;
            Prijs = prijs;
            Waterproof = waterproof;
        }


        public void ToonDetails()
        {
            if (Waterproof)
            {
                Console.WriteLine($"Waterproof {Merknaam} {Modelnaam}, {Prijs} euro.");

            }
            else
            {
                Console.WriteLine($"{Merknaam} {Modelnaam}, {Prijs} euro.");

            }
        }

        public void Bellen()
        {
            Console.WriteLine("GSM belt.");
        }
    }
}
