using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    public class MijnQueue : Queue<int>
    {

        public void NummerVragen()
        {
            Random r = new Random();
            int rInt;
            if (Count < 100)
            {
                do
                {
                    rInt = r.Next(1, 100 + 1);
                } while (Contains(rInt));
                Enqueue(rInt);
                Console.WriteLine($"Nummer {rInt} toegevoegd aan wachtrij.");
            }
            else
            {
                Console.WriteLine("Wachtrij te lang. Kom later terug.");
            }
            Console.WriteLine();
        }

        public void VolgendTonen()
        {
            TryPeek(out int result);
            Console.WriteLine($"Volgend nummer is {result}.");
            Console.WriteLine();
        }

        public void Afroepen()
        {
            if (TryDequeue(out int item))
            {
                Dequeue();
                Console.WriteLine($"Het is aan nummer {item}.");
            }
            else
            {
                Console.WriteLine("Geen mensen in wachtrij meer.");
            }
            Console.WriteLine();
        }

        public void Controleren()
        {
            Console.WriteLine("Geef nummer in om te controleren.");
            int nummer = int.Parse(Console.ReadLine());
            if (Contains(nummer))
            {
                Console.WriteLine($"{nummer} is aanwezig in de wachtrij.");
            }
            else
            {
                Console.WriteLine($"{nummer} is niet aanwezig in de wachtrij.");
            }
            Console.WriteLine();
        }

    }
}
