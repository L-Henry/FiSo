using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Winkelmand winkelmand = new Winkelmand();

            string command = "";
            while (command != "99")
            {
                Console.WriteLine();
                Console.WriteLine("Wat doen?");
                Console.WriteLine("1) Voeg product toe.");
                Console.WriteLine("2) Toon overzicht van producten.");
                Console.WriteLine("3) Bereken totaalprijs.");
                Console.WriteLine("4) Verwijder product.");
                Console.WriteLine("5) Maak mand leeg.");

                Console.WriteLine("99) Quit.");
                Console.WriteLine();
                command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        Console.WriteLine("Geef product in: Merknaam, Productnaam, Prijs.");
                        string[] product = Console.ReadLine().Split();
                        Product nieuwProduct = new Product(product[0], product[1], int.Parse(product[2]));
                        winkelmand.VoegProductToe(nieuwProduct);
                        break;
                    case "2":
                        winkelmand.ToonProductOverzicht();
                        break;
                    case "3":
                        winkelmand.BerekenTotaalPrijs();
                        break;
                    case "4":
                        Console.WriteLine("Geef in welk product");
                        int welk = int.Parse(Console.ReadLine());
                        winkelmand.VerwijderProduct(welk);
                        break;
                    case "5":
                        winkelmand.MaakMandjeLeeg();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
