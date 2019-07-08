using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekemachine_met_classes
{
    class Program
    {

        static void Main(string[] args)
        {
            Rekenmachine rekenmachine = new Rekenmachine();

            /*
            do
            {

                string[,] bewerkingen = new string[,] {
                { "5*2","10"}
                ,{ "12/4","3"}
                ,{ "1+4","5"}
                ,{ "1-4","-3"}
                ,{ "5*2*4","40"}
                ,{ "12/4/3","1"}
                ,{ "1+4+5","10"}
                ,{ "-10-6-5", "-21"}
                ,{ "10-6-5", "-1" }
                ,{ "10+-6-5", "-1"}
                ,{ "5*2/5*6","12"}
                ,{ "5*-1","-5"}
                ,{ "(5+5)","10"}
                ,{ "((5+5))","10"}
                ,{ "3+(5+5)+4","17"}
                ,{ "(1+1)*(1*-1)","-2"}
                };

                int rijen = bewerkingen.GetLength(0);
                rekenmachine.Bereken(bewerkingen[0, 0]);
                Stopwatch stopWatchTemp = new Stopwatch();
                stopWatchTemp.Start();
                stopWatchTemp.Stop();
                long totaalAantalTicks = 0;

                for (int rij = 0; rij < rijen; rij++)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();

                    double resultaat = rekenmachine.Bereken(bewerkingen[rij, 0]);


                    stopwatch.Stop();
                    string c = rekenmachine.Bereken(bewerkingen[rij, 0]) == double.Parse(bewerkingen[rij, 1]) ? "Correct" : "Niet correct";
                    Console.WriteLine($"Bewerking {bewerkingen[rij, 0]} {c}");
                    Console.WriteLine($"Ticks: {stopwatch.ElapsedTicks}");
                    totaalAantalTicks += stopwatch.ElapsedTicks;


                }
                Console.WriteLine($"Totaal: {totaalAantalTicks}");
                Console.WriteLine($"Gemiddeld {totaalAantalTicks / rijen}");
            } while (Console.ReadLine() != "9");
            */

            /*
            Console.WriteLine("Geef getal in.");
            string get1 = Console.ReadLine();
            Console.WriteLine($"{rekenmachine.Binair(get1)}");
            */

            /*
            Console.WriteLine("1) voor decimaal -> binair");
            Console.WriteLine("2) voor binair -> decimaal");
            int richting = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef getal in voor convertering.");
            string binair = Console.ReadLine();

            Console.WriteLine(Binair(binair, richting));
            */

            
            Console.WriteLine("Geef calculatie in.");
            string input = Console.ReadLine().Replace(" ", "");
            Console.WriteLine(rekenmachine.Bereken(input));
            

            Console.ReadLine();
        }
    }
}
