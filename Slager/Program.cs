using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> que = new Queue<int>();
            

            string command = "";
            do
            {
                Console.WriteLine("Wat doen?");
                Console.WriteLine("1) Nummer vragen.");
                Console.WriteLine("2) Volgend nummer tonen.");
                Console.WriteLine("3) Volgend nummer afroepen.");
                Console.WriteLine("4) Controleren nummer aanwezig is.");
                Console.WriteLine("9) Exit");
                Console.WriteLine();
                command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        Random r = new Random();
                        int rInt;
                        if (que.Count < 100)
                        {
                            do
                            {
                                rInt = r.Next(1, 100 + 1);
                            } while (que.Contains(rInt));
                            que.Enqueue(rInt);
                            Console.WriteLine($"Nummer {rInt} toegevoegd aan wachtrij.");
                        }
                        else
                        {
                            Console.WriteLine("Wachtrij te lang. Kom later terug.");
                        }
                        Console.WriteLine();
                        break;
                    case "2":
                        que.TryPeek(out int result);
                        Console.WriteLine($"Volgend nummer is {result}.");
                        Console.WriteLine();
                        break;
                    case "3":
                        if (que.TryDequeue(out int item))
                        {
                            que.Dequeue();
                            Console.WriteLine($"Het is aan nummer {item}.");
                        }
                        else
                        {
                            Console.WriteLine("Geen mensen in wachtrij meer.");
                        }
                        Console.WriteLine();
                        break;

                    case "4":
                        Console.WriteLine("Geef nummer in om te controleren.");
                        int nummer = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (que.Contains(nummer))
                        {
                            Console.WriteLine($"{nummer} is aanwezig in de wachtrij.");
                        }
                        else
                        {
                            Console.WriteLine($"{nummer} is niet aanwezig in de wachtrij.");
                        }
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            } while (command != "9");
        }
    }
}
