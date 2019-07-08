using System;
using System.Collections.Generic;
using System.Text;

namespace LinqProject
{
    public class Persoon
    {
        public string Naam { get; set; }
        public DateTime GeboorteDatum { get; set; }

        public Persoon(string naam, DateTime datum)
        {
            Naam = naam;
            GeboorteDatum = datum;
        }

        public Persoon()
        {

        }

    }
}
