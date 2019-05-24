using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selecties
{
    class Program
    {
        enum Instructie { Optellen, Aftrekken }

        static int Bereken(Instructie instructie, int get1, int get2)
        {
            
            switch (instructie)
            {
                case Instructie.Optellen:
                    return get1 + get2;
                case Instructie.Aftrekken:
                    return get1 - get2;
                default:
                    return 0;
            }
        }

        static void Main(string[] args)
        {
            Instructie inst;
            Console.WriteLine("Geef instructie:");

            /*if (Console.ReadLine() == "Optellen")
            { 
                inst = Instructie.Optellen;
            }
            else
            {
                inst = Instructie.Aftrekken;
            }
            */
            switch (Console.ReadLine())
            {
                case "Optellen":
                    inst = Instructie.Optellen;
                    break;
                case "Aftrekken":
                    inst = Instructie.Aftrekken;
                    break;
                default:
                    inst = 0;
                    break;
            }

            Console.WriteLine("Geef getal 1");
            int get1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef getal 2");
            int get2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Bereken(inst, get1, get2));
            
            /*
            string teken;
            int getal = Convert.ToInt32(Console.ReadLine());

            if (getal >= 0)
            {
                teken = "+";
            }
            else
            {
                teken = "-";
            }

            string teken2 = getal >= 0 ? "+" : "-";

            Console.WriteLine($"Teken van {getal} is {teken}");
            Console.WriteLine($"Teken2 van {getal} is {teken2}");
            */

            /*
            int leeftijd = Convert.ToInt32(Console.ReadLine());
            decimal prijs;
            if (leeftijd <= 3)
            {
                prijs = 0;
            }
            else if (leeftijd > 3 && leeftijd <= 18)
            {
                prijs = 10;
            }
            else if (leeftijd > 65)
            {
                prijs = 20;
            }
            else
            {
                prijs = 15;
            }
            Console.WriteLine($"De prijs is {prijs} euro.");
            */

            /*
            DayOfWeek dag = DayOfWeek.Saturday;

            switch (dag)
            {
                case DayOfWeek.Sunday:
                    break;
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                default:
                    break;
            }
            */
            /*
            string taal = Console.ReadLine().ToUpper();
            //taal = taal.ToUpper();

            switch (taal)
            {
                case "NL":
                    Console.WriteLine("Goeiedag!");
                    break;
                case "FR":
                    Console.WriteLine("Bonjour!");
                    break;
                case "EN":
                    Console.WriteLine("Good Day!");
                    break;
                default:
                    Console.WriteLine("Goeiedag, bonjour and good day!");
                    break;
            }
            */
           
            Console.ReadLine();
            
            
        }

        
    }
}
