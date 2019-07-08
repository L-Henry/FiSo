using System;

namespace Dier_overerven
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();

            Merel merel = new Merel("Merel Tsjirp");
            Mus mus1 = new Mus("Mus Tsjirp");
            Gorilla gorilla1 = new Gorilla();
            Neusaap neusaap1 = new Neusaap();
            Rund rund1 = new Rund("Moooo");
            
            zoo._dieren[0] = merel;
            zoo._dieren[1] = mus1;
            zoo.VoegDierToe(gorilla1); //index 2
            zoo.VoegDierToe(neusaap1); //index 3
            zoo.VoegDierToe(rund1); //index 4

            string commando;
            do
            {
                Console.WriteLine("Wat wilt u doen?");
                Console.WriteLine("1) Een dier toevoegen.");
                Console.WriteLine("9) Exit.");
                commando = Console.ReadLine();
                Console.WriteLine();
                switch (commando)
                {
                    case "1":
                        string input;
                        do
                        {
                            Console.WriteLine("Kies dier.");
                            Console.WriteLine("1) Een rund.");
                            Console.WriteLine("2) Een merel.");
                            Console.WriteLine("3) Een Krokodil.");
                            Console.WriteLine("9) Terug");
                            input = Console.ReadLine();
                            Console.WriteLine();
                            switch (input)
                            {
                                case "1":
                                    Console.WriteLine("Voeg geluid toe dat dier maakt.");
                                    string geluid1 = Console.ReadLine();
                                    Console.WriteLine();
                                    zoo.VoegDierToe(new Rund(geluid1));
                                    break;
                                case "2":
                                    Console.WriteLine("Voeg geluid toe dat dier maakt, of niet.");
                                    string geluid2 = Console.ReadLine();
                                    Console.WriteLine();
                                    if (geluid2 == null)
                                    {
                                        zoo.VoegDierToe(new Merel());
                                    }
                                    else
                                    {
                                        zoo.VoegDierToe(new Merel(geluid2));
                                    }
                                    break;
                                case "3":
                                    zoo.VoegDierToe(new Krokodil());
                                    break;
                                default:
                                    break;
                            }
                        } while (input != "9");
                        break;
                    default:
                        break;
                }
            } while (commando != "9");




            Console.ReadLine();

        }
    }
}
