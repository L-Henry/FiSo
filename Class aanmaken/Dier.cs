using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_aanmaken
{
    public class Dier
    {
        private readonly string _naam;

        //private bool _leeftNog;
        public bool LeeftNog { get; private set; }
        /*{
            get
            {
                return _leeftNog;
            }
        }*/

        public string Geluid { get; }

        private int _aantalPoten;
        public int AantalPoten
        {
            get
            {
                return _aantalPoten;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Moet poten hebben.");
                }
                _aantalPoten = value;
            }
        }

        public Dier(string naam, string geluid, int aantalPoten, bool leeft = true)
        {
            _naam = naam;
            Geluid = geluid;
            AantalPoten = aantalPoten;
            LeeftNog = leeft;
        }

        public void GeefGeluid()
        {
            Console.WriteLine($"{_naam} maakt het geluid {Geluid}.");
        }

        public void Sterf()
        {
            if (LeeftNog == false)
            {
                Console.WriteLine($"{_naam} is al dood. We gaan reanimeren.");
                Reanimatie();
                GeefGeluid();
            }
            else
            {
                LeeftNog = false;
            } 
        }

        public void Reanimatie()
        {
            if (LeeftNog == false)
            {
                LeeftNog = true;
                Console.WriteLine($"{_naam} leeft terug.");
            }
            else
            {
                Console.WriteLine($"{_naam} leeft nog.");
            }
        }
    }
}
