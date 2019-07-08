using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avondsessie
{
    class Program
    {
        static void Main(string[] args)
        {

            Kalender kalender = new Kalender();

            Sessie sessie1 = new Sessie("Les 1", "Lesgever 1", "Beschrijving 1", 2, "Gent", new DateTime(2021, 6, 6));
            kalender.VoegSessieToe(sessie1);
            Sessie sessie2 = new Sessie("Les 1", "Lesgever 1", "Beschrijving 1", 12, "Gent", new DateTime(2020, 6, 6));
            kalender.VoegSessieToe(sessie2);
            Sessie sessie3 = new Sessie("Les 1", "Lesgever 1", "Beschrijving 1", 5, "Gent", new DateTime(2017, 6, 6));
            kalender.VoegSessieToe(sessie3);
            Sessie sessie4 = new Sessie("Les 1", "Lesgever 1", "Beschrijving 1", 100, "Gent", new DateTime(2019, 6, 6));
            kalender.VoegSessieToe(sessie4);
            Sessie sessie5 = new Sessie("Les 1", "Lesgever 1", "Beschrijving 1", 32, "Gent", new DateTime(2019, 1, 6));
            kalender.VoegSessieToe(sessie5);

            string command = "";
            while (command != "9")
            {
                Console.WriteLine();
                Console.WriteLine("Wat doen?");
                Console.WriteLine("1) Toon kalender, lijst van sessies.");
                Console.WriteLine("2) Voeg Sessie toe.");
                Console.WriteLine("3) Verwijder sessie.");
                Console.WriteLine("4) Toon sessiedetails.");

                Console.WriteLine("9) Quit.");
                Console.WriteLine();
                command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        kalender.ToonSessies();
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine("Geef sessie gegevens in. ");
                        Console.WriteLine("Titel, lesgever, beschrijving, maximum aantal personen, locatie, datum");
                        string[] input = Console.ReadLine().Split();
                        Sessie nieuweSessie = new Sessie(input[0], input[1], input[2], int.Parse(input[3]), input[4], DateTime.Parse(input[5]));
                        kalender.VoegSessieToe(nieuweSessie);
                        break;
                    case "3":
                        Console.WriteLine("Welke sessie verwijderen?");
                        int welk = int.Parse(Console.ReadLine());
                        kalender.VerwijderSessie(welk);
                        break;
                    case "4":
                        Console.WriteLine("Welke sessie wil u zien?");
                        int welke = int.Parse(Console.ReadLine());
                        kalender.ToonSessieDetails(welke);
                        Console.WriteLine();
                        int commando = 0;
                        while (commando != 9)
                        {
                            Console.WriteLine("1) Voor deelnemer toevoegen.");
                            Console.WriteLine("2) Voor deelnemer verwijderen.");
                            Console.WriteLine("3) Pas deelnemer aan.");
                            Console.WriteLine("4) Sessie deelnemers tonen");
                            Console.WriteLine("9) Voor terug te gaan.");
                            Console.WriteLine();
                            commando = int.Parse(Console.ReadLine());
                            switch (commando)
                            {
                                case 1:
                                    Console.WriteLine("Geef gegevens in voor toevoegen of typ 99 om terug te gaan.");
                                    Console.WriteLine("Naam, voornaam, bedrijf, extra info.");
                                    string[] deelnemersInput = Console.ReadLine().Split();
                                    Deelnemer nieuweDeelnemer = new Deelnemer(deelnemersInput[0], deelnemersInput[1], deelnemersInput[2], deelnemersInput[3]);
                                    kalender.Sessies[welke - 1].VoegDeelnemerToe(nieuweDeelnemer);
                                    break;
                                case 2:
                                    Console.WriteLine("Welke deelnemer verwijderen?");
                                    int welkeVerwijderen = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"Deelnemer {kalender.Sessies[welke - 1].Deelnemers[welkeVerwijderen - 1].Naam} {kalender.Sessies[welke - 1].Deelnemers[welkeVerwijderen - 1].Voornaam} is verwijdert.");
                                    Console.WriteLine();
                                    kalender.Sessies[welke - 1].VerwijderDeelnemer(welkeVerwijderen);
                                    break;
                                case 3:
                                    Console.WriteLine("Welke deelnemer?");
                                    int welkeDeelnemer = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    Console.WriteLine("Wat wil u aanpassen? 'Naam', 'voornaam', 'bedrijf', of 'extra info'.");
                                    Console.WriteLine("Of geef '9' in om terug te gaan.");
                                    string inputInfo = Console.ReadLine().ToUpper();

                                    while (inputInfo != "9")
                                    {
                                        switch (inputInfo)
                                        {
                                            case "NAAM":
                                                Console.WriteLine("Geef naam in.");
                                                string naam = Console.ReadLine();
                                                kalender.Sessies[welke - 1].Deelnemers[welkeDeelnemer - 1].PasNaamAan(naam);
                                                inputInfo = "9";
                                                break;
                                            case "VOORNAAM":
                                                Console.WriteLine("Geef voornaam in.");
                                                string voornaam = Console.ReadLine();
                                                kalender.Sessies[welke - 1].Deelnemers[welkeDeelnemer - 1].PasVoornaamAan(voornaam);
                                                inputInfo = "9";
                                                break;
                                            case "BEDRIJF":
                                                Console.WriteLine("Geef bedrijf in.");
                                                string bedrijf = Console.ReadLine();
                                                kalender.Sessies[welke - 1].Deelnemers[welkeDeelnemer - 1].PasBedrijfAan(bedrijf);
                                                inputInfo = "9";
                                                break;
                                            case "EXTRA INFO":
                                                Console.WriteLine("Geef extra info in.");
                                                string info = Console.ReadLine();
                                                kalender.Sessies[welke - 1].Deelnemers[welkeDeelnemer - 1].PasExtraInfoAan(info);
                                                inputInfo = "9";
                                                break;
                                            default:
                                                Console.WriteLine("Probeer opnieuw met 'naam', 'voornaam', 'bedrijf', 'extra info'.");
                                                break;
                                        }
                                    }
                                    break;
                                case 4:
                                    kalender.Sessies[welke - 1].ToonDeelnemers();
                                    Console.WriteLine();
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }



        }
    }
}
