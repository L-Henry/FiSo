using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace types
{
    class Program
    {
        static void Main(string[] args)
        {
            bool lichtenStatus = false;
            decimal prijs = 123.66M;
            int huidigVerdiepLift = 8;
            int bierKoelkast = 0;
            double complexeBerekening = 88 / Math.Pow(55,5);
            double complexeBerekening2 = 88 / 55.0;

            int bewerking1 = 8 * 88;
            double bewerking2 = Math.Pow(55,5);
            var test = bewerking1 / bewerking2;

            string stukTekst = "Woorden maken een zin.";

            int getal1 = 400;
            int getal2 = 500;
            getal1 = getal2;
            getal2 = getal2 + 500;
            Console.WriteLine(getal1 + ", " + getal2);
            getal1 = getal2;
            Console.WriteLine(getal1 + ", " + getal2);

            Console.WriteLine("Status lichten is: " + lichtenStatus);
            Console.WriteLine("Resultaat berekening is: " + complexeBerekening);
            Console.WriteLine("Resultaat berekening is: " + complexeBerekening2);
            Console.WriteLine("Prijs: {1} {2}{0}", "dollar", prijs, "euro");
            Console.WriteLine("Huidige verdieping: " + huidigVerdiepLift);
            Console.WriteLine("Pinten: " + bierKoelkast);
            Console.WriteLine("Tekst: " + stukTekst);
            Console.ReadLine();
        }
    }
}
