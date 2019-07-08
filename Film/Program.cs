using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film
{
    class Program
    {

        static void Main(string[] args)
        {

            RegisseurManager manager = new RegisseurManager();
            Regisseur nolan = new Regisseur("Nolan", new DateTime(1975, 6, 11));
            manager.VoegRegisseurToe(nolan);
            Cinema cinema = new Cinema("Kinepolis", "Gent");

            Film film1 = new Film("Film 1", "Beschrijving 1", "Horror", nolan, 120, new DateTime(2021, 6, 6));
            cinema.VoegFilmsToe(film1);
            Film film2 = new Film("Film 2", "Beschrijving 2", "Sci-fi", nolan, 90, new DateTime(2020, 6, 6));
            cinema.VoegFilmsToe(film2);
            Film film3 = new Film("Film 3", "Beschrijving 3", "Fantasy", nolan, 50, new DateTime(2017, 6, 6));
            cinema.VoegFilmsToe(film3);
            Film film4 = new Film("Film 4", "Beschrijving 4", "Comedy", nolan, 120, new DateTime(2019, 6, 6));
            cinema.VoegFilmsToe(film4);
            Film film5 = new Film("Film 5", "Beschrijving 5", "Action", nolan, 150, new DateTime(2019, 5, 29));
            cinema.VoegFilmsToe(film5);

            string command;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Wat doen?");
                Console.WriteLine("1) Toon voorstellingen vandaag.");
                Console.WriteLine("2) Toon verleden films.");
                Console.WriteLine("3) Toon komende films.");
                Console.WriteLine("4) Voeg film toe.");

                Console.WriteLine("9) Quit.");
                Console.WriteLine();
                command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        cinema.FilmsVoorVandaag();
                        Console.WriteLine();
                        break;
                    case "2":
                        cinema.FilmsInHetVerleden();
                        Console.WriteLine();
                        break;
                    case "3":
                        cinema.FilmsInDeToekomst();
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine("Geef gegevens in voor toevoegen film.");
                        Console.WriteLine("Titel, Beschrijving, genre, regisseur, duur, afspeeldatum.");
                        string[] filmInput = Console.ReadLine().Split(',');
                        Film nieuweFilm = new Film(filmInput[0], filmInput[1], filmInput[2], manager.VindRegisseur(filmInput[3].Trim()), Convert.ToInt32(filmInput[4]), Convert.ToDateTime(filmInput[5]));
                        cinema.VoegFilmsToe(nieuweFilm);                       
                        break;
                    default:
                        break;
                }
            } while (command != "9") ;






            //Console.ReadLine();


        }
    }
}
