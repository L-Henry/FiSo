using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drankautomaat
{
    class Program
    {
        static void Main(string[] args)
        {
            DrankAutomaat automaat = new DrankAutomaat();

            DrankStock cola = new DrankStock("Cola", 0.9M, 50);
            automaat.VoegStockToe(cola);
            DrankStock fanta = new DrankStock("Fanta", 1.1M, 1);
            automaat.VoegStockToe(fanta);

            int input = 0;
            do
            {
                Console.WriteLine("Wat wil u doen?");
                Console.WriteLine("1) Toon beschikbare dranken.");
                Console.WriteLine("2) Steek geld in automaat.");
                Console.WriteLine("3) Koop een drank.");
                Console.WriteLine("4) Voeg drank toe.");

                Console.WriteLine("9) Quit.");
                Console.WriteLine();
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        automaat.ToonBeschikbareDranken();
                        break;
                    case 2:
                        Console.WriteLine("Geef in hoeveel.");
                        decimal hoeveel = decimal.Parse(Console.ReadLine());
                        automaat.SteekGeldInAutomaat(hoeveel);
                        break;
                    case 3:
                        automaat.KoopDrank();
                        break;
                    case 4:
                        automaat.VoegStockToe();
                        break;
                    default:
                        break;
                }
            } while (input != 9);



        }
    }
}
