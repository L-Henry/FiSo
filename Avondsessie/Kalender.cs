using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avondsessie
{
    class Kalender
    {
        public Sessie[] Sessies { get; private set; }

        public Kalender()
        {
            Sessies = new Sessie[0];
        }

        internal void VoegSessieToe(Sessie nieuweSessie)
        {
            Sessie[] _sessieTemp = new Sessie[Sessies.Length + 1];
            for (int i = 0; i < _sessieTemp.Length - 1; i++)
            {
                _sessieTemp[i] = Sessies[i];
            }
            _sessieTemp[_sessieTemp.Length - 1] = nieuweSessie;
            Sessies = _sessieTemp;
        }

        internal void ToonSessies()
        {
            Sorteer();
            Console.WriteLine("Verlopen sessies:");
            int teller = 0;
            for (int i = 0; i < Sessies.Length; i++)
            {
                if (Sessies[i].Verlopen == true)
                {
                    Console.WriteLine($"{i + 1}) {Sessies[i].Titel} was {Sessies[i].DagenTot()} dagen geleden.");
                    teller++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Nog te komen sessies:");
            for (int i = teller; i < Sessies.Length; i++)
            {
                if (Sessies[i].Verlopen == false)
                {
                    Console.WriteLine($"{i + 1}) {Sessies[i].Titel} was {Sessies[i].DagenTot()} dagen geleden.");
                }
            }
            Console.WriteLine();

        }

        internal void ToonSessieDetails(int welk)
        {
            if (welk > Sessies.Length || welk < 1)
            {
                Console.WriteLine("Deze sessie bestaat niet.");
            }
            else
            {
                Console.WriteLine($"Sessie details:");
                Console.WriteLine($"Titel: {Sessies[welk - 1].Titel}");
                Console.WriteLine($"Lesgever: {Sessies[welk - 1].Lesgever}");
                Console.WriteLine($"Beschrijving: {Sessies[welk - 1].Beschrijving}");
                Console.WriteLine($"Locatie: {Sessies[welk - 1].Locatie}");
                Console.WriteLine($"Aantal deelnemers: {Sessies[welk - 1].Deelnemers.Length} / {Sessies[welk - 1].MaxPersonen}");
                for (int i = 0; i < Sessies[welk - 1].Deelnemers.Length; i++)
                {
                    Console.WriteLine($"Deelnemers {i + 1}: {Sessies[welk - 1].Deelnemers[i].Voornaam} {Sessies[welk - 1].Deelnemers[i].Naam} van {Sessies[welk - 1].Deelnemers[i].Bedrijf}.");
                }
            }
            Console.WriteLine();
        }

        internal void VerwijderSessie(int welk)
        {
            Sessie[] _sessieTemp = new Sessie[Sessies.Length - 1];
            for (int i = 0; i < welk - 1; i++)
            {
                _sessieTemp[i] = Sessies[i];
            }
            for (int i = welk - 1; i < _sessieTemp.Length; i++)
            {
                _sessieTemp[i] = Sessies[i + 1];
            }
            Sessies = _sessieTemp;
        }

        internal Sessie[] Sorteer()
        {
            for (int i = 0; i < Sessies.Length; i++)
            {
                for (int j = i; j < Sessies.Length; j++)
                {
                    if (Sessies[j].Datum < Sessies[i].Datum)
                    {
                        Sessie vergelijk = Sessies[i];
                        Sessies[i] = Sessies[j];
                        Sessies[j] = vergelijk;
                    }
                }
            }
            return Sessies;
        }
    }
}
