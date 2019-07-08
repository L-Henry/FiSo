using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huis_en_kamers
{


    class Huis
    {
        public Kamer[] Kamers { get; set; }
        private Bewoner[] _bewoners;

        public string Adres { get; }
        public string Type { get; }
        //public Kamer Woonkamer { get; }
        //public Bewoner Hoofdbewoner { get; }
        public int MaxBewoners { get; }
        public int MaxKamers { get; set; }

        public Huis(string adres, string type, int maxBewoners, int maxKamers)
        {
            Adres = adres;
            Type = type;
            //Woonkamer = kamer;
            //Hoofdbewoner = bewoner;
            MaxBewoners = maxBewoners;
            MaxKamers = maxBewoners;

            Kamers = new Kamer[0];
            _bewoners = new Bewoner[0];

        }

        public void ToonKamersBewoners()
        {
            Console.WriteLine("Kamers:");
            for (int i = 0; i < Kamers.Length; i++)
            {
                Console.WriteLine($"{i+1}) {Kamers[i].Type}, {Kamers[i].Oppervlakte}m²");
            }
            Console.WriteLine();
            Console.WriteLine("Bewoners:");
            for (int i = 0; i < _bewoners.Length; i++)
            {
                Console.WriteLine($"{i+1}) {_bewoners[i].Naam}");
            }
            Console.WriteLine();

            /*
            Console.WriteLine("Kamers:");
            foreach (Kamer kamer in _kamers)
            {
                Console.WriteLine($"{Array.IndexOf(_kamers, kamer)+1}) {kamer.Type}, {kamer.Oppervlakte}m²");

            }
            Console.WriteLine("Bewoners:");
            foreach (Bewoner bewoner in _bewoners)
            {
                Console.WriteLine($"{Array.IndexOf(_bewoners, bewoner) + 1}) {bewoner.Naam}");
            }
            */
        }


        public void VoegBewonerToe(Bewoner bewoner)
        {
            if (_bewoners.Length < MaxBewoners)
            {
                Bewoner[] _bewonersTemp = new Bewoner[_bewoners.Length + 1];
                for (int i = 0; i < _bewonersTemp.Length - 1; i++)
                {
                    _bewonersTemp[i] = _bewoners[i];
                }
                _bewonersTemp[_bewonersTemp.Length - 1] = bewoner;
                _bewoners = _bewonersTemp;
            }
            else
            {
                Console.WriteLine("Maximum aantal bewoners reeds bereikt.");
                Console.WriteLine();
            }
        }

        public void VoegKamerToe(Kamer kamer)
        {
            if (Kamers.Length < MaxKamers)
            {
                Kamer[] _kamersTemp = new Kamer[Kamers.Length + 1];
                for (int i = 0; i < _kamersTemp.Length - 1; i++)
                {
                    _kamersTemp[i] = Kamers[i];
                }
                _kamersTemp[_kamersTemp.Length - 1] = kamer;
                Kamers = _kamersTemp;
            }
            else
            {
                Console.WriteLine("Maximum aantal kamers reeds bereikt.");
                Console.WriteLine();
            }
        }

        public void VerwijderBewoner(int welke)
        {
            Bewoner[] _bewonersTemp = new Bewoner[_bewoners.Length - 1];
            for (int i = 0; i < _bewonersTemp.Length; i++)
            {
                if (i < welke - 1)
                {
                    _bewonersTemp[i] = _bewoners[i];
                }
                else
                {
                    _bewonersTemp[i] = _bewoners[i + 1];
                }
            }
            _bewoners = _bewonersTemp;
        }

        public void VerwijderKamer(int welke)
        {
            Kamer[] _kamersTemp = new Kamer[Kamers.Length - 1];
            for (int i = 0; i < _kamersTemp.Length; i++)
            {
                if (i < welke - 1)
                {
                    _kamersTemp[i] = Kamers[i];
                }
                else
                {
                    _kamersTemp[i] = Kamers[i + 1];
                }
            }
            Kamers = _kamersTemp;
        }

    }


    


   
}
