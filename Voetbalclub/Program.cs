using System;
using System.Collections.Generic;

namespace Voetbalclub
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> club = new List<string>(100);

            List<string> ploeg = new List<string>(11);

            string command = "";
            do
            {
                Console.WriteLine("Wat doen?");
                Console.WriteLine("1) Speler toevoegen");
                Console.WriteLine("2) Speler verwijderen.");
                Console.WriteLine("3) Aantal voetballers opvragen.");
                Console.WriteLine("4) Sorteren.");
                Console.WriteLine("5) Oplijsten.");
                Console.WriteLine("6) Ploeg samenstellen.");
                Console.WriteLine("7) Ploeg tonen.");
                Console.WriteLine("9) Exit.");
                Console.WriteLine();
                command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        do
                        {
                            Console.WriteLine("Geef naam in.");
                            string naam = Console.ReadLine();
                            club.Add(naam);
                            Console.WriteLine("Nog toevoegen? y/n");
                            command = Console.ReadLine();
                            Console.WriteLine();
                        } while (command != "n");
                        break;
                    case "2":
                        Console.WriteLine("Geef index van te verwijderen speler.");
                        int index = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        club.Remove(club[index - 1]);
                        break;
                    case "3":
                        Console.WriteLine(club.Count);
                        Console.WriteLine();
                        break;
                    case "4":
                        club.Sort();
                        break;
                    case "5":
                        for (int i = 0; i < club.Count; i++)
                        {
                            Console.WriteLine($"{i+1}) {club[i]}");
                        }
                        Console.WriteLine();
                        break;
                    case "6":
                        string[] nummers;
                        do
                        {
                            Console.WriteLine("Geef nummers in.");
                            nummers = Console.ReadLine().Split(',');
                            for (int i = 0; i < nummers.Length; i++)
                            {
                                ploeg.Add(club[int.Parse(nummers[i].Trim()) - 1]);
                            }
                            Console.WriteLine("Nog nummers ingeven? y/n");
                            nummers[0] = Console.ReadLine();
                            Console.WriteLine();
                        } while (nummers[0] != "n");
                        break;
                    case "7":
                        for (int i = 0; i < ploeg.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}) {ploeg[i]}");
                        }
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            } while (command != "9");
        }
    }
}
