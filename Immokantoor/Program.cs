using System;

namespace Immokantoor
{
    class Program
    {
        static void Main(string[] args)
        {
            ImmoKantoor immo = new ImmoKantoor("Immoimmo");

            Huis huis1 = new Huis("Astraat 1", 1, "Rood", 200000, true);
            Huis huis2 = new Huis("Astraat 2", 5, "zwart", 600000, false);
            Appartement app1 = new Appartement("Bstraat 3", "B", 2, 220000, true, true);
            Appartement app2 = new Appartement("Bstraat 4", "B3", 3, 320000, false, false);

            immo.VoegGebouwToe(huis1);
            immo.VoegGebouwToe(huis1);
            immo.VoegGebouwToe(app1);
            immo.VoegGebouwToe(app2);

            string commando;
            do
            {
                Console.WriteLine("Wat wilt u doen?");
                Console.WriteLine("1) Een pand toevoegen.");
                Console.WriteLine("2) Alle huizen tonen.");
                Console.WriteLine("3) Alle appartementen tonen.");
                Console.WriteLine("9) Exit.");
                commando = Console.ReadLine();
                Console.WriteLine();
                switch (commando)
                {
                    case "1":
                        string input;
                        do
                        {
                            Console.WriteLine("Kies type pand.");
                            Console.WriteLine("1) Een huis.");
                            Console.WriteLine("2) Een appartement.");
                            Console.WriteLine("9) Terug");
                            input = Console.ReadLine();
                            Console.WriteLine();
                            switch (input)
                            {
                                case "1":
                                    Console.WriteLine("Geef in: adres, aantal slaapkamers, dak kleur, prijs, nieuwbouw.");
                                    string[] nieuwHuis = Console.ReadLine().Split(',');
                                    Console.WriteLine();
                                    immo.VoegGebouwToe(new Huis(nieuwHuis[0], int.Parse(nieuwHuis[1]), nieuwHuis[2], decimal.Parse(nieuwHuis[3]), bool.Parse(nieuwHuis[4])));
                                    break;
                                case "2":
                                    Console.WriteLine("Geef in: adres, bus, aantal slaapkamers, prijs, lift aanwezig, nieuwbouw.");
                                    string[] nieuwApp = Console.ReadLine().Split(',');
                                    Console.WriteLine();
                                    immo.VoegGebouwToe(new Appartement(nieuwApp[0], nieuwApp[1], int.Parse(nieuwApp[2]), decimal.Parse(nieuwApp[3]), bool.Parse(nieuwApp[4]), bool.Parse(nieuwApp[5])));
                                    break;
                                default:
                                    break;
                            }
                        } while (input != "9");
                        break;
                    case "2":
                        immo.ToonMijAlleHuizen();
                        break;
                    case "3":
                        immo.ToonMijAlleAppartementen();
                        break;
                    default:
                        break;
                }
            } while (commando != "9");

        }
    }
}
