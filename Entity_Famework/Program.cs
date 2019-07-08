using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Famework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AutoContext())
            {
                /*
                var bestuurder1 = new Bestuurder { Naam = "Bert Bibber" };
                var bestuurder2 = new Bestuurder { Naam = "Piet Pienter" };
                var bestuurder3 = new Bestuurder { Naam = "Jens Larssen" };
                

                context.Autos.Add(new Auto { Naam = "Auto1", Bestuurder = bestuurder1 });
                context.Autos.Add(new Auto { Naam = "Auto2", Bestuurder = bestuurder2 });
                context.Autos.Add(new Auto { Naam = "Auto3", Bestuurder = bestuurder3 });
                context.Autos.Add(new Auto { Naam = "Auto4", Bestuurder = bestuurder1 });
                
                context.SaveChanges();
                */
                
                var autos = context.Autos.Where(auto => auto.Naam.Contains("auto1")).ToList();
                /*
                var auto6 = context.Autos.Include("Bestuurder").SingleOrDefault(auto => auto.Id == 6);
                var auto6Tweede = context.Autos.SingleOrDefault(auto => auto.Id == 6);
                Console.WriteLine(auto6.Bestuurder.Naam);
                var auto7 = context.Autos.SingleOrDefault(auto => auto.Id == 7);
                Console.WriteLine(auto7.Bestuurder.Naam);
                */

                foreach (var auto in autos)
                {
                    Console.WriteLine($"Id: {auto.Id}, Naam: {auto.Naam}.");
                }

            }


            Console.ReadLine();
        }
    }
}
