using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVoornaam
{
    public class Persoon
    {
        public string Voornaam { get; set; }
        public Color Kleur { get; set; }
        /*
        public string VoornaamKleur
        {
            get
            {
                return Voornaam + ", " + Kleur;
            }
        }
        */

        public Persoon(string voornaam, Color kleur)
        {
            Voornaam = voornaam;
            Kleur = kleur;
        }

        public Persoon()
        {

        }

        
        public override string ToString()
        {
            return Voornaam + ", " + Kleur.Name;
        }

    }
}
