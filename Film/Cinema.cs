using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film
{
    class Cinema
    {
        public string Naam { get; }
        public string Locatie { get; }
        public Film[] Films { get; private set; }
        

        public Cinema(string naam, string locatie)
        {
            Naam = naam;
            Locatie = locatie;
            Films = new Film[0];
        }

        internal void VoegFilmsToe(Film film)
        {
            Film[] _filmsTemp = new Film[Films.Length + 1];
            for (int i = 0; i < Films.Length; i++)
            {
                _filmsTemp[i] = Films[i];
            }
            _filmsTemp[_filmsTemp.Length - 1] = film;
            Films = _filmsTemp;
        }

        internal void FilmsVoorVandaag()
        {
            for (int i = 0; i < Films.Length; i++)
            {
                if (Films[i].Afspeeldatum == DateTime.Today)
                {
                    Console.WriteLine($"{Films[i].Titel}, {Films[i].Genre}, {Films[i].Beschrijving}, {Films[i].Duur}");
                }
            }

        }

        internal void FilmsInHetVerleden()
        {
            for (int i = 0; i < Films.Length; i++)
            {
                if (Films[i].Afspeeldatum < DateTime.Today)
                {
                    Console.WriteLine($"{Films[i].Titel}, {Films[i].Genre}, {Films[i].Beschrijving}, {Films[i].Duur}");
                }
            }
        }

        internal void FilmsInDeToekomst()
        {
            for (int i = 0; i < Films.Length; i++)
            {
                if (Films[i].Afspeeldatum > DateTime.Today)
                {
                    Console.WriteLine($"{Films[i].Titel}, {Films[i].Genre}, {Films[i].Beschrijving}, {Films[i].Duur}");
                }
            }
        }


    }
}
