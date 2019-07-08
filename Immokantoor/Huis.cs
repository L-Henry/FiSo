using System;
using System.Collections.Generic;
using System.Text;

namespace Immokantoor
{
    class Huis : Gebouw
    {
        public string DakpanKleur { get; set; }

        public Huis(string adres, int kamers, string dakpanKleur, decimal prijs, bool nieuwbouw = false) : base(adres, kamers, prijs, nieuwbouw)
        {
            DakpanKleur = dakpanKleur;
        }


        public override void WatZijnMijnDetails()
        {
            string nieuwbouwString = "";
            if (Nieuwbouw)
            {
                nieuwbouwString = "nieuwbouw ";
            }
            Console.WriteLine($"Dit {nieuwbouwString}pand is gelegen te {Adres}, heeft {AantalKamers} slaapkamers en kost {Prijs} euro. Keur van dak is {DakpanKleur}");
        }

    }
}
