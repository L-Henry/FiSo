using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        public static IEnumerable<int> LijstGetallen()
        {
            Console.WriteLine("Doe iets.");
            yield return 10;
            Console.WriteLine("Doe iets.");
            yield return -2;
            Console.WriteLine("Doe iets.");
            yield return 2;
            Console.WriteLine("Doe iets.");
            yield return 5;
            Console.WriteLine("Doe iets.");
            yield return -3;
        }


        static void Main(string[] args)
        {
            List<int> getallen = new List<int> { 10, -9, 2, 20, -3 };
            List<int> negatieveGetallen = new List<int>();

            Console.WriteLine("Met foreach.");
            foreach (int item in getallen)
            {
                if (item < 0)
                {
                    negatieveGetallen.Add(item);
                }
            }
            foreach (int item in negatieveGetallen)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Met Linq");
            IEnumerable<int> negatieveGetallenLinq = from getal in getallen
                                                     where getal < 0
                                                     select getal;
            foreach (int item in negatieveGetallenLinq)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            List<Persoon> personen = new List<Persoon>()
            {
                new Persoon() { Naam = "Bert", GeboorteDatum = new DateTime(1988,3,28)},
                new Persoon() { Naam = "Bert", GeboorteDatum = new DateTime(1989,4,28)},
                new Persoon() { Naam = "NietBert", GeboorteDatum = new DateTime(1990,5,28)},
                new Persoon() { Naam = "Harold", GeboorteDatum = new DateTime(1990,9,2)},
            };

            Console.WriteLine("Personen");
            IEnumerable<Persoon> personenMetNaamBert = from persoon in personen
                                                       where persoon.Naam == "Bert"
                                                       select persoon;
            foreach (Persoon persoon in personenMetNaamBert)
            {
                Console.WriteLine($"Persoon: {persoon.Naam}");
            }

            Console.WriteLine();
            Console.WriteLine("Datums van Bert.");
            IEnumerable<DateTime> datumsBert = from persoon in personen
                                               where persoon.Naam == "Bert"
                                               select persoon.GeboorteDatum;
            foreach (DateTime datum in datumsBert)
            {
                Console.WriteLine(datum);
            }

            Console.WriteLine();
            Console.WriteLine("Lazy evaluation.");
            IEnumerable<int> lijstGetallen = LijstGetallen().ToList();
            
            foreach (int getal in lijstGetallen)
            {
                ;
            }
            foreach (int getal in lijstGetallen)
            {
                ;
            }

            Console.WriteLine();
            Console.WriteLine("Anonymous");
            var bertDatum = from persoon in personen
                            where persoon.Naam == "Bert" && persoon.GeboorteDatum.Year >= 1989
                            select new { persoon.GeboorteDatum.Year, persoon.Naam, OK = true, Nummer = 1 };
            bertDatum.ToList();
            foreach (var persoon in bertDatum)
            {
                Console.WriteLine($"Persoon: {persoon.Naam}, Geboorte: {persoon.Year}, Check: {persoon.OK}");
            }

            Console.WriteLine();
            Console.WriteLine("Group");

            int[] getallenGroep = new int[] { 1, 3, 5, 10, 100, 1000, 6 };
            var evenGroep = from getal in getallenGroep
                            group getal by getal % 2 == 0 into even
                            select even;
            foreach (var groep in evenGroep)
            {
                Console.WriteLine("Is even? " + groep.Key);
                foreach (var getal in groep)
                {
                    Console.Write(getal + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Groeperen per beginletter.");
            var personenBeginLetter = from persoon in personen
                                      group persoon by persoon.Naam[0] into beginLetter
                                      select beginLetter;
            foreach (var letter in personenBeginLetter)
            {
                Console.WriteLine($"Namen die beginnen met {letter.Key}.");
                int teller = 1;
                foreach (var naam in letter)
                {
                    Console.WriteLine($"{teller}) {naam.Naam}, {naam.GeboorteDatum.Year}");
                    teller++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Groeperen per geboortejaar.");
            var personenGeboorteDatum = from persoon in personen
                                        group persoon by persoon.GeboorteDatum.Year into jaren
                                        select jaren;
            foreach (var jaar in personenGeboorteDatum)
            {
                Console.WriteLine($"Persone geboren in {jaar.Key}.");
                int teller = 1;
                foreach (var persoon in jaar)
                {
                    Console.WriteLine($"{teller}) {persoon.Naam}, {persoon.GeboorteDatum.Year}");
                    teller++;
                }
            }


            Console.ReadLine();
        }
    }
}
