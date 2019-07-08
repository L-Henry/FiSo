using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huis_en_kamers
{
    class Program
    {
        static void Main(string[] args)
        {

            int adressen = 2; //huizen in straat
            Huis[] huizen = new Huis[adressen];

            Huis huis1 = new Huis("Kortstraat 2", "Rijhuis", 5, 5);
            Huis huis2 = new Huis("Kortstraat 4", "Half open", 2, 4);

            huizen[0] = huis1;
            huizen[1] = huis2;

            // Huis 1 kamers
            Kamer woonkamer = new Kamer("Woonkamer", 5, 6);
            huis1.VoegKamerToe(woonkamer);
            Kamer keuken = new Kamer("Keuken", 3, 5);
            huis1.VoegKamerToe(keuken);
            Kamer slaapkamer = new Kamer("Slaapkamer", 5,5);
            huis1.VoegKamerToe(slaapkamer);
            Kamer badkamer = new Kamer("Badkamer", 3,4);
            huis1.VoegKamerToe(badkamer);
            Kamer toilet = new Kamer("Toilet", 2,2);
            huis1.VoegKamerToe(toilet);

            // Huis 2 kamers
            Kamer woonkamer2 = new Kamer("Woonkamer", 4, 5);
            huis2.VoegKamerToe(woonkamer2);
            Kamer keuken2 = new Kamer("Keuken", 4, 5);
            huis2.VoegKamerToe(keuken2);
            Kamer slaapkamer2 = new Kamer("Slaapkamer", 3, 5);
            huis2.VoegKamerToe(slaapkamer2);

            // Huis 1 bewoners
            Bewoner bewoner1 = new Bewoner("Anna", "Paulon", "Gent", new DateTime(1988-2-20));
            huis1.VoegBewonerToe(bewoner1);
            Bewoner bewoner2 = new Bewoner("Paul", "Rondt", "Lokeren", new DateTime(1990-2-30));
            huis1.VoegBewonerToe(bewoner2);
            Bewoner bewoner3 = new Bewoner("Arya", "Stark", "Gent", new DateTime(2016-6-16));
            huis1.VoegBewonerToe(bewoner3);

            // Huis 2 bewoners
            Bewoner bewoner1Huis2 = new Bewoner("Anna", "Paulon", "Gent", new DateTime(1988 - 2 - 20));
            huis2.VoegBewonerToe(bewoner1Huis2);
            Bewoner bewoner2Huis2 = new Bewoner("Paul", "Rondt", "Lokeren", new DateTime(1990 - 2 - 30));
            huis2.VoegBewonerToe(bewoner2Huis2);


            Console.WriteLine("Kies adres");
            for (int i = 0; i < huizen.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {huizen[i].Adres} ({huizen[i].Type})");
            }
            int adres = int.Parse(Console.ReadLine());
            int commando;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Wat doen?");
                Console.WriteLine("1) Toon overzicht kamers en bewoners.");
                Console.WriteLine("2) Voeg bewoner toe.");
                Console.WriteLine("3) Voeg kamer toe.");
                Console.WriteLine("4) Verwijder bewoner.");
                Console.WriteLine("5) Verwijder kamer.");
                Console.WriteLine("6) Meubel toevoegen.");
                Console.WriteLine("7) Meubel tonen.");
                Console.WriteLine("8) Voor ander huis.");
                Console.WriteLine("9) voor exit.");
                commando = int.Parse(Console.ReadLine());
                if (commando == 1)
                {
                    huizen[adres-1].ToonKamersBewoners();
                    Console.WriteLine();
                }
                else if (commando == 2)
                {
                    Console.WriteLine("Geef in: Voornaam, achternaam, Geboortelocatie, Geboortedatum");
                    string[] input = Console.ReadLine().Split();
                    Bewoner nieuweBewoner = new Bewoner(input[0], input[1], input[2], DateTime.Parse(input[3]));
                    huizen[adres-1].VoegBewonerToe(nieuweBewoner);
                    Console.WriteLine();
                }
                else if (commando == 3)
                {
                    Console.WriteLine("Geef in: Type kamer, lengte, breedte");
                    string[] input = Console.ReadLine().Split();
                    Kamer nieuweKamer = new Kamer(input[0], int.Parse(input[1]), int.Parse(input[2]));
                    huizen[adres-1].VoegKamerToe(nieuweKamer);
                    Console.WriteLine();
                }
                else if (commando == 4)
                {
                    Console.WriteLine("Welke?");
                    int input = int.Parse(Console.ReadLine());
                    huizen[adres-1].VerwijderBewoner(input);
                    Console.WriteLine();
                }
                else if (commando == 5)
                {
                    Console.WriteLine("Welke");
                    int input = int.Parse(Console.ReadLine());
                    huizen[adres-1].VerwijderKamer(input);
                    Console.WriteLine();
                }
                else if (commando == 6)
                {
                    Console.WriteLine("Geef kamer in");
                    string kamerInput = Console.ReadLine();
                    bool bestaatKamer = true;
                    foreach (Kamer kamer in huizen[adres-1].Kamers)
                    {
                        if (kamer.Type != kamerInput)
                        {
                            bestaatKamer = false;
                        }
                        else
                        {
                            Console.WriteLine("Geef type van meubel in.");
                            string meubelInput = Console.ReadLine();
                            Meubel nieuweMeubel = new Meubel(meubelInput);
                            kamer.VoegMeubelToe(nieuweMeubel);
                            bestaatKamer = true;
                            break;
                        }
                        
                    }
                    if (bestaatKamer == false)
                    {
                        Console.WriteLine("Kamer bestaat niet.");
                        Console.WriteLine();
                    }
                }
                else if (commando == 7)
                {
                    Console.WriteLine("Geef kamer in");
                    string kamerInput = Console.ReadLine();
                    bool bestaatKamer = true;
                  
                    
                    foreach (Kamer kamer in huizen[adres - 1].Kamers)
                    {
                        if (kamer.Type == kamerInput)
                        {
                            kamer.ToonMeubels();
                            bestaatKamer = true;
                            break;
                        }
                        else
                        {
                            bestaatKamer = false;
                        }
                        
                    }  
                    if (bestaatKamer == false)
                    {
                        Console.WriteLine("Kamer bestaat niet.");
                        Console.WriteLine();
                    }
                }
                else if (commando == 8)
                {
                    Console.WriteLine("Kies adres");
                    for (int i = 0; i < huizen.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}) {huizen[i].Adres} ({huizen[i].Type})");
                    }
                    Console.WriteLine();
                    adres = int.Parse(Console.ReadLine());
                }
            } while (commando != 9);


            //Console.ReadLine();

        }
    }
}
