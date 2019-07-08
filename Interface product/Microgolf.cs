using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_product
{
    class Microgolf : IProduct
    {
        public string Merknaam { get; set; }
        public string Modelnaam { get; set; }
        public decimal Prijs { get; set; }
        public int AantalWatt { get; set; }

        public Microgolf(string merkNaam, string modelNaam, decimal prijs, int watt)
        {
            Merknaam = merkNaam;
            Modelnaam = modelNaam;
            Prijs = prijs;
            AantalWatt = watt;
        }

        public void ToonDetails()
        {
            Console.WriteLine($"{Merknaam} {Modelnaam} met vermogen van {AantalWatt} watt, {Prijs} euro.");
        }

        public void EtenOpwarmen()
        {
            Console.WriteLine("Eten is warm.");
        }

    }
}
