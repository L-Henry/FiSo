using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film
{
    class Film
    {
        public string Titel { get; }
        public string Beschrijving { get; }

        public string Genre { get; }
        public Regisseur Regisseur { get; }
        public int Duur { get; }
        public DateTime Afspeeldatum { get; }

        public Film(string titel, string beschrijving, string genre, Regisseur regisseur, int duur, DateTime datum)
        {
            Titel = titel;
            Beschrijving = beschrijving;
            Genre = genre;
            Regisseur = regisseur;
            Duur = duur;
            Afspeeldatum = datum;
        }


    }
}
