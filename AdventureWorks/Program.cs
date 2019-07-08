using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Data.Entity.Infrastructure;

namespace AdventureWorks
{
    class Program
    {

        static void Lezen()
        {
            Console.WriteLine("Geef ID in.");
            int keuzeID = int.Parse(Console.ReadLine());

            using (var context = new AWContext())
            {
                var adressen = context.Addresses.Where(address => address.AddressID == keuzeID).ToList();

                foreach (var adres in adressen)
                {
                    Console.WriteLine($"{adres.AddressID}) {adres.AddressLine1}, {adres.AddressLine2} te {adres.City}, {adres.StateProvinceID}");
                }
            }
        }

        static void Aanmaken()
        {
            Console.WriteLine("Geef details in:");
            Console.WriteLine("Adres, stad, ProvinceId, Postcode");
            Console.WriteLine();
            string[] nieuwAdres = Console.ReadLine().Split(',');

            using (var context = new AWContext())
            {
                context.Addresses.Add(new Address { AddressLine1 = nieuwAdres[0], City = nieuwAdres[1], StateProvinceID = int.Parse(nieuwAdres[2].Trim()),
                            PostalCode = nieuwAdres[3].Trim(), ModifiedDate = DateTime.Now, rowguid = Guid.NewGuid() });

                DisplayTrackedEntities(context.ChangeTracker);
                context.SaveChanges();
            }
        }

        static void Aanpassen()
        {
            Console.WriteLine("Geef id in van record dat u wil aanpassen.");
            int keuzeID = int.Parse(Console.ReadLine());
            Console.WriteLine("Geef nieuw adres in: adres, stad, postcode, statepovindeID.");
            string[] geupdateAdres = Console.ReadLine().Split(',');

            using (var context = new AWContext())
            {
                var record = context.Addresses.SingleOrDefault(adres => adres.AddressID == keuzeID);
                if (record != null)
                {/*
                    Address nieuwRecord = new Address
                    {
                        AddressLine1 = geupdateAdres[0],
                        City = geupdateAdres[1].Trim(),
                        StateProvinceID = int.Parse(geupdateAdres[3].Trim()),
                        PostalCode = geupdateAdres[2].Trim(),
                        ModifiedDate = record.ModifiedDate,
                        rowguid = record.rowguid
                    };*/
                    record.AddressLine1 = geupdateAdres[0].Trim();
                    record.City = geupdateAdres[1].Trim();
                    record.PostalCode = geupdateAdres[2].Trim();
                    record.StateProvinceID = int.Parse(geupdateAdres[3].Trim());

                    DisplayTrackedEntities(context.ChangeTracker);

                    context.SaveChanges();
                }
            }
        }

        static void Verwijderen()
        {
            using (var context = new AWContext())
            {
                var laatste = context.Addresses.Where(adres => adres.AddressID > 0).OrderByDescending(id => id.AddressID).First();
                Console.WriteLine($"laatste id: {laatste.AddressID}");

                Console.WriteLine("Welke record wil u verwijderen?");
                int keuzeID = int.Parse(Console.ReadLine());

                var record = context.Addresses.SingleOrDefault(adres => adres.AddressID == keuzeID);
                if (record != null)
                {
                    context.Addresses.Remove(record);
                }

                DisplayTrackedEntities(context.ChangeTracker);

                context.SaveChanges();
            }
        }

        static void Main(string[] args)
        {
            //Aanmaken();
            //Lezen();
            //Aanpassen();
            Verwijderen();


            Console.ReadLine();
        }

        private static void DisplayTrackedEntities(DbChangeTracker changeTracker)
        {
            var entries = changeTracker.Entries();
            foreach (var entry in entries)
            {
                Console.WriteLine("Entity Name: {0}", entry.Entity.GetType().FullName);
                Console.WriteLine("Status: {0}", entry.State);
            }
        }

    }

    

}
