using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huis_en_kamers
{
    class Bewoner
    {
        public string Voornaam { get; }
        public string Achternaam { get; }
        public string Naam
        {
            get
            {
                return Voornaam + " " + Achternaam;
            }
        }
        public string GeborenIn { get; }
        public DateTime GeborenOp { get; }

        public Bewoner(string voornaam, string achternaam, string locatie, DateTime datum)
        {
            Achternaam = achternaam;
            Voornaam = voornaam;
            GeborenIn = locatie;
            GeborenOp = datum;
        }
    }
}
