using System;
using System.Drawing;

namespace FigurenCore
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Geef figuur in, met coordinaat van middelpunt.");
            string[] coosNieuwFiguur = Console.ReadLine().Split();
            int xNieuwFiguur = int.Parse(coosNieuwFiguur[0]);
            int yNieuwFiguur = int.Parse(coosNieuwFiguur[1]);

            Point nieuwPoint = new Point(xNieuwFiguur, yNieuwFiguur);
            Figuur nieuwFiguur = new Figuur(nieuwPoint);

            double result = nieuwFiguur.BerekenAfstand(new Point(10, 10));
            Console.WriteLine(result);
            */

            Vierkant testVierkant = new Vierkant(new Point(5, 5), 5);
            Cirkel testCirkel = new Cirkel(new Point(10,10), 5);

            Console.WriteLine($"Omtrek vierkant = {testVierkant.BerekenOmtrek()} cm, Oppervlakte vierkant = {testVierkant.BerekenOppervlakte()} cm²");
            Console.WriteLine($"Omtrek cirkel = {testCirkel.BerekenOmtrek()} cm, Oppervlakte cirkel = {testCirkel.BerekenOppervlakte()} cm²");

            double result = testCirkel.BerekenAfstand(testVierkant);
            Console.WriteLine($"Afstand tussen middelpunten = {result} cm.");


            



            Console.ReadLine();
            
        }
    }
}
