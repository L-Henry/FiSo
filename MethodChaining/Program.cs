using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodChaining
{
    class Persoon
    {
        public string Naam { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Geslacht { get; set; }

        public Persoon()
        {

        }
    }

    class Geslacht
    {
        public string Code { get; set; }
        public string Omschrijving { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {
            List<Persoon> personen = new List<Persoon>()
            {
                new Persoon() { Naam = "Bert", GeboorteDatum = new DateTime(1988,3,28)},
                new Persoon() { Naam = "Bert", GeboorteDatum = new DateTime(1989,4,2)},
                new Persoon() { Naam = "NietBert", GeboorteDatum = new DateTime(1990,5,28)},
                new Persoon() { Naam = "Harold", GeboorteDatum = new DateTime(1990,9,2)},
            };

            var personenMetBert = personen.Where(person => person.Naam == "Bert")
                                          .OrderBy(person => person.GeboorteDatum.Day)
                                          .Select(person => new { person.Naam, person.GeboorteDatum, OK = "Ok"});

            foreach (var persoon in personenMetBert)
            {
                Console.WriteLine($"Persoon: {persoon.Naam}, {persoon.GeboorteDatum}, Status: {persoon.OK}");
            }


            Console.WriteLine();
            Console.WriteLine("Groeperen");
            int[] getallenGroep = new int[] { 1, 3, 5, 10, 100, 1000, 6 };
            var groeperen = getallenGroep.GroupBy(getal => getal % 2 == 0);

            foreach (var groep in groeperen)
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
            var perBeginLetter = personen.GroupBy(naam => naam.Naam);

            foreach (var letter in perBeginLetter)
            {
                Console.WriteLine($"Namen die beginnen met {letter.Key}.");
                int teller = 1;
                foreach (var naam in letter)
                {
                    Console.WriteLine($"{teller}) {naam.Naam}, {naam.GeboorteDatum.Year}");
                    teller++;
                }
            }


            List<Geslacht> geslachen = new List<Geslacht>
            {
                new Geslacht { Code = "M", Omschrijving = "Man"},
                new Geslacht { Code = "V", Omschrijving = "Vrouw"},
                new Geslacht { Code = "X", Omschrijving = "Neutraal"}
            };

            List<Persoon> personenMetGeslacht = new List<Persoon>()
            {
                new Persoon() { Naam = "Bert", GeboorteDatum = new DateTime(1988,3,28), Geslacht = "M"},
                new Persoon() { Naam = "Bert", GeboorteDatum = new DateTime(1989,4,28), Geslacht = "X" },
                new Persoon() { Naam = "NietBert", GeboorteDatum = new DateTime(1990,5,28), Geslacht = "V" },
                new Persoon() { Naam = "Harold", GeboorteDatum = new DateTime(1990,9,2), Geslacht = "M"},
            };

            var personenPerGeslacht = personenMetGeslacht.Join(geslachen,
                                                              persoon => persoon.Geslacht,
                                                              geslacht => geslacht.Code,
                                                              (persoon, geslacht) => persoon.Naam + " is een " + geslacht.Omschrijving);
            Console.WriteLine();
            Console.WriteLine("Join naam en geslacht.");
            foreach (var item in personenPerGeslacht)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
