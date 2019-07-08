using System;
using System.Collections.Generic;
using System.Text;

namespace Vastgoed_met_interface
{
    class Vastgoed : IConsoleWriteable
    {

        public string Adres { get; set; }
        public int AantalKamers { get; set; }
        public decimal Prijs { get; set; }
        public bool Nieuwbouw { get; set; }

        public Vastgoed(string adres, int kamers, decimal prijs, bool nieuwbouw = false)
        {
            Adres = adres;
            AantalKamers = kamers;
            Prijs = prijs;
            Nieuwbouw = nieuwbouw;
        }

        public void SchrijfDetailsNaarConsole()
        {
            string nieuwbouwString = "";
            if (Nieuwbouw)
            {
                nieuwbouwString = "nieuwbouw ";
            }
            Console.WriteLine($"Dit {nieuwbouwString}pand is gelegen te {Adres}, heeft {AantalKamers} slaapkamers en kost {Prijs} euro.");
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
