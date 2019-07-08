using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_product
{
    class Koelkast : IProduct
    {
        public string Merknaam { get; set; }
        public string Modelnaam { get; set; }
        public decimal Prijs { get; set; }
        public string Kleur { get; set; }

        public Koelkast(string merkNaam, string modelNaam, decimal prijs, string kleur)
        {
            Merknaam = merkNaam;
            Modelnaam = modelNaam;
            Prijs = prijs;
            Kleur = kleur;
        }

        public void ToonDetails()
        {
            Console.WriteLine($"{Kleur} {Merknaam} {Modelnaam}, {Prijs} euro.");
        }

        public void KoudWorden()
        {
            Console.WriteLine("Eten koelt.");
        }
    }
}
