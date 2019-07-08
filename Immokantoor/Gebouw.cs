using System;
using System.Collections.Generic;
using System.Text;

namespace Immokantoor
{
    class Gebouw
    {
        public string Adres { get; set; }
        public int AantalKamers { get; set; }
        public decimal Prijs { get; set; }
        public bool Nieuwbouw { get; set; }

        public Gebouw(string adres, int kamers, decimal prijs, bool nieuwbouw = false)
        {
            Adres = adres;
            AantalKamers = kamers;
            Prijs = prijs;
            Nieuwbouw = nieuwbouw;
        }

        public virtual void WatZijnMijnDetails()
        {
            string nieuwbouwString = "";
            if (Nieuwbouw)
            {
                nieuwbouwString = "nieuwbouw ";
            }
            Console.WriteLine($"Dit {nieuwbouwString}pand is gelegen te {Adres}, heeft {AantalKamers} slaapkamers en kost {Prijs} euro.");
        }

    }
}
