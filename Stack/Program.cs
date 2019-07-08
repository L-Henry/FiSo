using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {


        static void Main(string[] args)
        {
            Spel spel = new Spel(3);

            do
            {
                spel.Print();


                Console.WriteLine("Selecteer stack.");
                int keuze = int.Parse(Console.ReadLine()) - 1;

                Console.WriteLine("Naar welke stack verplaatsen? 1, 2 of 3");
                int naarWelke = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine();

                if (spel.HetSpel[keuze].TryPeek(out Schijf schijf))
                {
                    if (!spel.HetSpel[naarWelke].TryPeek(out Schijf peekSchijf) || schijf.Grootte < peekSchijf.Grootte)
                    {
                        spel.HetSpel[keuze].Pop();
                        spel.HetSpel[naarWelke].Push(schijf);
                    }
                    else
                    {
                        Console.WriteLine("Illegale move.");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Geen schijf aanwezig in deze stack.");
                    Console.WriteLine();
                }
               


            } while (true);






            Console.ReadLine();
        }
    }
}
