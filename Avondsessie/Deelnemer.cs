using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avondsessie
{
    class Deelnemer
    {

        public string Naam { get; private set; }
        public string Voornaam { get; private set; }

        public string Bedrijf { get; private set; }
        public string ExtraInfo { get; private set; }



        public Deelnemer(string naam, string voornaam, string bedrijf, string info)
        {
            Naam = naam;
            Voornaam = voornaam;
            Bedrijf = bedrijf;
            ExtraInfo = info;
        }

        internal void PasNaamAan(string naam)
        {
            Naam = naam;
        }

        internal void PasVoornaamAan(string voornaam)
        {
            Voornaam = voornaam;
        }

        internal void PasBedrijfAan(string bedrijf)
        {
            Bedrijf = bedrijf;
        }

        internal void PasExtraInfoAan(string info)
        {
            ExtraInfo = info;
        }


    }
}
