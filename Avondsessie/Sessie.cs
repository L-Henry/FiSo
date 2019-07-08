using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avondsessie
{
    class Sessie
    {
        public DateTime Datum { get; private set; }
        public string Titel { get;  }
        public string Lesgever { get;  }
        public string Beschrijving { get;  }
        public int MaxPersonen { get; private set; }
        public string Locatie { get; private set; }
        public Deelnemer[] Deelnemers { get; private set; }
        public bool Verlopen
        {
            get
            {
                if (DateTime.Compare(DateTime.Now, Datum) < 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }


        public Sessie(string titel, string lesgever, string beschrijving, int maxPersonen, string locatie, DateTime datum)
        {
            Titel = titel;
            Lesgever = lesgever;
            Beschrijving = beschrijving;
            MaxPersonen = maxPersonen;
            Locatie = locatie;
            Deelnemers = new Deelnemer[0];
            Datum = datum;
        }


        internal void VoegDeelnemerToe(Deelnemer nieuweDeelnemer)
        {
            if (Deelnemers.Length < MaxPersonen)
            {
                Deelnemer[] _deelnemersTemp = new Deelnemer[Deelnemers.Length + 1];
                for (int i = 0; i < _deelnemersTemp.Length - 1; i++)
                {
                    _deelnemersTemp[i] = Deelnemers[i];
                }
                _deelnemersTemp[_deelnemersTemp.Length - 1] = nieuweDeelnemer;
                Deelnemers = _deelnemersTemp;
            }
            else
            {
                Console.WriteLine("Max aantal deelnemers reeds bereikt. Kan deelnemer niet toevoegen.");
                Console.WriteLine();
            }
        }

        internal void VerwijderDeelnemer(int welk)
        {
            Deelnemer[] _deelnemersTemp = new Deelnemer[Deelnemers.Length - 1];
            for (int i = 0; i < welk - 1; i++)
            {
                _deelnemersTemp[i] = Deelnemers[i];
            }
            for (int i = welk - 1; i < _deelnemersTemp.Length - 1; i++)
            {
                _deelnemersTemp[i] = Deelnemers[i + 1];
            }
            Deelnemers = _deelnemersTemp;
        }

        internal void ToonDeelnemers()
        {
            for (int i = 0; i < Deelnemers.Length; i++)
            {
                Console.WriteLine($"{i+1}) {Deelnemers[i].Naam} {Deelnemers[i].Voornaam} van {Deelnemers[i].Bedrijf}.");
            }
        }

        internal int DagenTot()
        {
            return Convert.ToInt32((Datum - DateTime.Now).TotalDays);
        }
    }
}
