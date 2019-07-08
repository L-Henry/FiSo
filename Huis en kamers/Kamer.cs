using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huis_en_kamers
{
    class Kamer
    {
        public string Type { get; }
        public int Oppervlakte
        {
            get
            {
                return Lengte * Breedte;
            }

        }
        public int Lengte { get; }
        public int Breedte { get; }

        private Meubel[] _meubels;


        public Kamer(string type, int lengte, int breedte)
        {
            Type = type;
            Lengte = lengte;
            Breedte = breedte;

            _meubels = new Meubel[0];
        }

        public void VoegMeubelToe(Meubel meubel)
        {
            Meubel[] _meubelsTemp = new Meubel[_meubels.Length + 1];
            for (int i = 0; i < _meubelsTemp.Length - 1; i++)
            {
                _meubelsTemp[i] = _meubels[i];
            }
            _meubelsTemp[_meubelsTemp.Length - 1] = meubel;
            _meubels = _meubelsTemp;
        }

        public void ToonMeubels()
        {
            Console.WriteLine("Meubels:");
            for (int i = 0; i < _meubels.Length; i++)
			{
                Console.WriteLine($"{i+1}) {_meubels[i].Naam}");
			}
            Console.WriteLine();
        }

    }
}
