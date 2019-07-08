using System;
using System.Collections.Generic;

namespace Booschappenlijst
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> lijst = new Dictionary<string, int>();

            string command = "";
            do
            {
                Console.WriteLine("Wat doen?");
                Console.WriteLine("1) Toevoegen.");
                Console.WriteLine("2) Aantal van artikel opvragen.");
                Console.WriteLine("3) Item verwijderen.");
                Console.WriteLine("4) Controleren of item voorkomt.");
                Console.WriteLine("5) Overzicht.");
                Console.WriteLine("9) Exit");
                Console.WriteLine();
                command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        string input = "";
                        do
                        {
                            Console.WriteLine("Geef naam artikel en aantal in.");
                            string[] nieuw = Console.ReadLine().Split();
                            if (lijst.ContainsKey(nieuw[0]))
                            {
                                lijst[nieuw[0]] += int.Parse(nieuw[1].Trim());
                            }
                            else
                            {
                                lijst.Add(nieuw[0], int.Parse(nieuw[1].Trim()));
                            }
                            Console.WriteLine("Nog toevoegen? y/n");
                            input = Console.ReadLine();
                        } while (input != "n");
                        break;
                    case "2":
                        Console.WriteLine("Geef artikel in.");
                        string artikel = Console.ReadLine();
                        lijst.TryGetValue(artikel, out int value);
                        Console.WriteLine($"Aantal van {artikel} is {value}.");
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine("Welk item verwijderen?");
                        string[] artikelVerwijder = Console.ReadLine().Split();
                        if (artikelVerwijder.Length > 1)
                        {
                            if (lijst.ContainsKey(artikelVerwijder[0]) && lijst[artikelVerwijder[0]] > int.Parse(artikelVerwijder[1].Trim()))
                            {
                                lijst[artikelVerwijder[0]] -= int.Parse(artikelVerwijder[1].Trim());
                            }
                            else
                            {
                                Console.WriteLine($"Boodschappenlijst bevat dit aantal van {artikelVerwijder[0]} niet."); ;
                            }
                        }
                        else
                        {
                            lijst.Remove(artikelVerwijder[0]);
                        }
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine("Welk artikel controleren?");
                        string controleerArtikel = Console.ReadLine();
                        if (lijst.ContainsKey(controleerArtikel))
                        {
                            Console.WriteLine($"Boodschappenlijst bevat {controleerArtikel}.");
                        }
                        else
                        {
                            Console.WriteLine($"Boodschappenlijst bevat {controleerArtikel} niet.");
                        }
                        Console.WriteLine();
                        break;
                    case "5":
                        int teller = 1;
                        foreach (KeyValuePair<string, int> item in lijst)
                        {
                            Console.WriteLine($"{teller}) {item.Key}, {item.Value} stuks.");
                            teller++;
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
