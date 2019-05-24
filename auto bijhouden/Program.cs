using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_bijhouden
{
    class Program
    {
        public static void ToonLijst(string[] lijst)
        {
            int dim2 = lijst.Length;
            for (int i = 0; i < dim2; i++)
            {
                Console.WriteLine(i + 1 + ") " + lijst[i]);
            }
        }

        public static string[] Toevoeg(string[] lijst, out string[] nieuwe)
        {
            int dim = lijst.Length;
            Console.WriteLine("Geef merk, model en bouwjaar in, of 0 voor terug.");
            string[] input = Console.ReadLine().Split();
            if (input[0] == "0")
            {
                nieuwe = lijst;
                return nieuwe;
            }
            nieuwe = new string[dim + 1];
            string entry = input[0] + " - " + input[1] + " - " + input[2];
            for (int i = 0; i < lijst.Length; i++)
            {
                nieuwe[i] = lijst[i];
            }
            nieuwe[dim] = entry;
            return nieuwe;
        }

        public static string[] PasAan(string[] lijst)
        {
            Console.WriteLine("Welke aanpassen? Typ 0 voor terug naar hoofdmenu.");
            int welke = int.Parse(Console.ReadLine());
            if (welke == 0)
            {
                return lijst;
            }
            Console.WriteLine("Geef merk, model en bouwjaar in, of 0 voor terug.");
            string[] input = Console.ReadLine().Split();
            if (input[0] == "0")
            {
                return lijst;
            }
            string entry = input[0] + " - " + input[1] + " - " + input[2];
            lijst[welke - 1] = entry;
            return lijst;
        }

        public static string[] Verwijder(string[] lijst, out string[] nieuwe)
        {
            int dim = lijst.Length;
            Console.WriteLine("Welke verwijderen? Of typ 0 voor terug.");
            int welke = int.Parse(Console.ReadLine());
            if (welke == 0)
            {
                nieuwe = lijst;
                return nieuwe;
            }

            nieuwe = new string[dim - 1];
            for (int i = 0; i < dim - 1; i++)
            {
                if (i < welke - 1)
                {
                    nieuwe[i] = lijst[i];
                }
                else
                {
                    nieuwe[i] = lijst[i + 1];
                }
            }
            return nieuwe;
        }

        static void Main(string[] args)
        {
            //string[] lijst = new string[0];
            string[] lijst = new string[] { "a a 1", "b b 2", "c c 3", "d d 4", "e e 5","g g 6", "f f 7","h h 8" };
            loop:
            Console.WriteLine("Wat wilt u doen?");
            Console.WriteLine("1 voor lijst tonen.");
            Console.WriteLine("2 voor toevoegen.");
            Console.WriteLine("3 voor aanpassen.");
            Console.WriteLine("4 voor verwijderen.");
            string input = Console.ReadLine();
            if (input == "1")
            {
                ToonLijst(lijst);
            }
            else if (input == "2")
            {
                Toevoeg(lijst, out lijst);
            }
            else if (input == "3")
            {
                PasAan(lijst);
            }
            else if(input == "4")
            {
                Verwijder(lijst, out lijst);
            }
            else
            {
                Console.WriteLine("Geef een geldig commando.");
            }
            goto loop;


            Console.ReadLine();
        }
    }
}
