using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film
{
    class Regisseur
    {
        public string Naam { get; }
        public DateTime GeboorteDatum { get; }
        public int Leeftijd
        {
            get
            {
                int jaren = DateTime.Now.Year - GeboorteDatum.Year;
                if (DateTime.Now.Month < GeboorteDatum.Month || ( DateTime.Now.Month == GeboorteDatum.Month && DateTime.Now.Day > GeboorteDatum.Day ))
                {
                    jaren--;
                }
                return jaren;
            }           
        }

        public Regisseur(string naam, DateTime datum)
        {
            Naam = naam;
            GeboorteDatum = datum;
        }



    }
}
