using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_aanmaken
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Auto lambo = new Auto("Lamborghini", 450, "Benzine");
            Console.WriteLine($"Kleur van de lambo = {lambo.Kleur}");
            lambo.Kleur = "Groen";
            Console.WriteLine($"Kleur van de lambo = {lambo.Kleur}");
            Auto legeAuto = new Auto();
            lambo.Start();
            lambo.Opdrijven(50);
            Console.WriteLine(lambo.Opdrijven(50));
            */
            
            Dier kat = new Dier("Kat", "Miauw", 4);
            Dier kip = new Dier("Kip", "tok", 2, true);

            loop:
            Console.WriteLine("Welk dier?");
            string dier = Console.ReadLine();
            
            Console.WriteLine($"Wat moet de {dier} doen?");
            Console.WriteLine("1) voor geluid maken.");
            Console.WriteLine("2) voor dood doen.");
            Console.WriteLine("3) voor reanimatie.");
            int commando = int.Parse(Console.ReadLine());
            if (commando == 1)
            {
                kip.GeefGeluid();
                Console.WriteLine();
            }
            else if (commando == 2)
            {
                kip.Sterf();
                Console.WriteLine();
            }
            else if (commando == 3)
            {
                kip.Reanimatie();
                Console.WriteLine();
            }
            goto loop;

            kat.GeefGeluid();
            Console.WriteLine(kip.AantalPoten);
            Console.WriteLine(kip.LeeftNog);
            kip.Sterf();
            kip.Sterf();
            Console.WriteLine(kip.LeeftNog);
            /*
            Console.WriteLine(kip.LeeftNog);
            kip.Reanimatie();
            kat.Reanimatie();
            Console.WriteLine(kip.LeeftNog);
            */


            Console.ReadLine();

            

        }
    }
}
