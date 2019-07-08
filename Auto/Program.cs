using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor ferrariMotor = new Motor(500, "Benzine", 9000);
            Motor bmwMotor = new Motor(300, "Benzine", 6500);
            Motor vwMotor = new Motor(160, "Diesel", 6000);
            Motor elektrisch = new Motor(300, "Batterij", 1);

            Auto ferrari = new Auto("Ferrari 488", "Rood", ferrariMotor, 120, 18, "Grundig");
            Auto bmwM4 = new Auto("BMW M4", "Zilver", bmwMotor, 120, 18, "Grundig");
            Auto vw = new Auto("Volkswagen", "Donkerblauw", vwMotor, 120, 18, "Bang&Olufsen");
            Auto eJaguar = new Auto("e-Jaguar", "Groen", elektrisch, 0, 18, "Bang&Olufsen");

            //int aantalAutos = 4;
            //Auto[] garage = new Auto[4];
            Auto[] garage = new Auto[] { ferrari, bmwM4, vw, eJaguar};


            int autoKeuze;
            Console.WriteLine("Welke wagen?");
            for (int i = 0; i < garage.Length; i++)
            {
                Console.WriteLine($"{i+1}) {garage[i].MerkNaam}");
            }
            autoKeuze = int.Parse(Console.ReadLine());


            string command = "";
            while (command != "99")
            {
                Console.WriteLine();
                Console.WriteLine("Wat doen?");
                Console.WriteLine("1) Start wagen.");
                Console.WriteLine("2) Stop wagen.");
                Console.WriteLine("3) Tanken.");
                Console.WriteLine("4) Gas geven.");
                Console.WriteLine("11) Radio aan");
                Console.WriteLine("12) Radio uit.");
                Console.WriteLine("13) Volume omhoog.");
                Console.WriteLine("14) Volume omlaag.");
                Console.WriteLine("15) Geef huidige zender.");
                Console.WriteLine("16) Verander zender.");

                Console.WriteLine("99) Exit.");
                Console.WriteLine();
                command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        garage[autoKeuze - 1].Start();
                        break;
                    case "2":
                        garage[autoKeuze - 1].Stop();
                        break;
                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("Hoeveel liter?");
                        int liter = int.Parse(Console.ReadLine());
                        garage[autoKeuze - 1].Tanken(liter);
                        break;
                    case "4":
                        garage[autoKeuze - 1].GeefGas();
                        break;

                    case "11":
                        garage[autoKeuze - 1].Radio.Aanzetten();
                        break;
                    case "12":
                        garage[autoKeuze - 1].Radio.Uitzetten();
                        break;
                    case "13":
                        garage[autoKeuze - 1].Radio.VerhoogVolume();
                        break;
                    case "14":
                        garage[autoKeuze - 1].Radio.VerlaagVolume();
                        break;
                    case "15":
                        Console.WriteLine(garage[autoKeuze - 1].Radio.HuidigeZender);
                        break;
                    case "16":
                        Console.WriteLine();
                        Console.WriteLine("Naar welke zender veranderen?");
                        string zender = Console.ReadLine();
                        garage[autoKeuze - 1].Radio.VeranderZender(zender);
                        break;
                    default:
                        break;
                }
            }



            //Console.ReadLine();
        }
    }
}
