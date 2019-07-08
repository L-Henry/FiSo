using System;
using System.Collections.Generic;
using System.Text;

namespace Immokantoor
{
    class Appartement : Gebouw
    {
        public string Busnummer { get; set; }
        public bool Lift { get; set; }

        public Appartement(string adres, string bus, int aantalKamers, decimal prijs, bool nieuwbouw = false, bool lift = true) : base(adres, aantalKamers, prijs, nieuwbouw)
        {
            Busnummer = bus;
            Lift = lift;
        }

        public bool IsLiftAanwezig()
        {
            return Lift;
        }

        public override void WatZijnMijnDetails()
        {
            string nieuwbouwString = "";
            if (Nieuwbouw)
            {
                nieuwbouwString = "nieuwbouw ";
            }
            if (Lift)
            {
                Console.WriteLine($"Dit {nieuwbouwString}pand is gelegen te {Adres} {Busnummer}, heeft {AantalKamers} slaapkamers, met lift, en kost {Prijs} euro.");

            }
            else
            {
                Console.WriteLine($"Dit {nieuwbouwString}pand is gelegen te {Adres} {Busnummer}, heeft {AantalKamers} slaapkamers, zonder lift, en kost {Prijs} euro.");

            }
        }

    }
}
