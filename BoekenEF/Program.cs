using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Data.Entity;

namespace BoekenEF
{
    class Program
    {
        static void AddRecord(int keuze)
        {
            using (var context = new BoekContext())
            {
                if (keuze == 1)
                {
                    Console.WriteLine("Geef naam van auteur in.");
                    string inputNaam = Console.ReadLine();

                    if (!context.Auteur.Any(a => a.Naam == inputNaam))
                    {
                        context.Auteur.Add(new Auteur { Naam = inputNaam });

                        Console.WriteLine($"Auteur {inputNaam} is toegoevoegd.");
                    }
                    else
                    {
                        Console.WriteLine("Auteur zit al in database.");
                        var aut = context.Auteur.SingleOrDefault(a => a.Naam == inputNaam);
                        Console.WriteLine($"{aut.AuteurId}) {aut.Naam}");
                    }                
                }
                else if (keuze == 2)
                {
                    Console.WriteLine("Geef naam van auteur in.");
                    string inputNaam = Console.ReadLine();

                    if (!context.Uitgever.Any(a => a.Naam == inputNaam))
                    {
                        context.Uitgever.Add(new Uitgeverij { Naam = inputNaam });

                        Console.WriteLine($"Uitgeverij {inputNaam} is toegoevoegd.");
                    }
                    else
                    {
                        Console.WriteLine("Uitgeverij zit al in database.");
                        var uit = context.Uitgever.SingleOrDefault(a => a.Naam == inputNaam);
                        Console.WriteLine($"{uit.UitgeverijId}) {uit.Naam}");
                    }
                }
                else if (keuze == 3)
                {
                    Console.WriteLine("Geef volgende in: ISBN nummer, Titel, Aantal paginas");
                    string[] inputWaarden = Console.ReadLine().Split(',');

                    if (!context.Boeken.Any(b => b.ISBN == inputWaarden[0]))
                    {
                        Console.WriteLine("Geef id van auteur in of 0 om nieuwe aan te maken.");
                        GeefWeer(1);
                        int aId = int.Parse(Console.ReadLine().Trim());
                        if (aId == 0)
                        {
                            Console.WriteLine("Geef naam in.");
                            string inputNaam = Console.ReadLine();
                            context.Auteur.Add(new Auteur { Naam = inputNaam });
                            aId = context.Auteur.Max(a => a.AuteurId);
                        }

                        Console.WriteLine("Geef id van uitgeverij in of 0 om nieuwe aan te maken.");
                        GeefWeer(2);
                        int uId = int.Parse(Console.ReadLine().Trim());
                        if (uId == 0)
                        {
                            Console.WriteLine("Geef naam in.");
                            string inputNaam = Console.ReadLine();
                            context.Uitgever.Add(new Uitgeverij { Naam = inputNaam });
                            uId = context.Uitgever.Max(a => a.UitgeverijId);
                        }

                        context.Boeken.Add(new Boek
                        {
                            ISBN = inputWaarden[0],
                            Titel = inputWaarden[1].Trim(),
                            PaginaAantal = int.Parse(inputWaarden[2].Trim()),
                            Auteur = context.Auteur.SingleOrDefault(a => a.AuteurId == aId),
                            Uitgeverij = context.Uitgever.SingleOrDefault(u => u.UitgeverijId == uId)
                        });
                        Console.WriteLine($"Boek {inputWaarden[0]}, {inputWaarden[1]} is toegoevoegd.");
                    }
                    else
                    {
                        Console.WriteLine("Boek zit al in database.");
                        var boek = context.Boeken.SingleOrDefault(b => b.ISBN == inputWaarden[0]);
                        Console.WriteLine($"{boek.Id}) {boek.ISBN} {boek.Titel}");
                    }                    
                }
                else
                {
                    Console.WriteLine("Ongeldige keuze.");
                }
                context.SaveChanges();
                Console.WriteLine();
            }
        }

        static void GeefWeer(int keuze)
        {
            if (keuze == 1)
            {
                using (var context = new BoekContext())
                {
                    var auteurs = context.Auteur;

                    foreach (var a in auteurs)
                    {
                        Console.WriteLine($"{a.AuteurId}) {a.Naam}");
                    }
                }
                Console.WriteLine();
            }
            else if (keuze == 2)
            {
                using (var context = new BoekContext())
                {
                    var uitgevers = context.Uitgever;

                    foreach (var u in uitgevers)
                    {
                        Console.WriteLine($"{u.UitgeverijId}) {u.Naam}");
                    }
                }
                Console.WriteLine();
            }
            else if (keuze == 3)
            {
                using (var context = new BoekContext())
                {
                    var boeken = context.Boeken;

                    foreach (var b in boeken)
                    {
                        Console.WriteLine($"{b.Id}) {b.ISBN}, {b.Titel}");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Ongeldige keuze");
                Console.WriteLine();
            }          
        }

        static void BoekDetails()
        {
            Console.WriteLine("Geef isbn in boek waarvan u details wil.");
            GeefWeer(3);
            string isbn = Console.ReadLine();

            using (var context = new BoekContext())
            {
                if (context.Boeken.Any(b => b.ISBN == isbn))
                {
                    var boek = context.Boeken.Include(a => a.Auteur).Include(u => u.Uitgeverij).SingleOrDefault(b => b.ISBN == isbn);
                    /*var boek = context.Boeken.Where(b => b.ISBN == isbn).Select(b => new
                    {
                        b.ISBN,
                        b.Titel,
                        b.PaginaAantal,
                        UitgeverijNaam = b.Uitgeverij.Naam,
                        AuteurNaam = b.Auteur.Naam
                    });*/

                    //Console.WriteLine($"{boek}");
                    Console.WriteLine($"{boek.Id}) {boek.ISBN}, {boek.Titel}, {boek.PaginaAantal} paginas" +
                        $", van {boek.Auteur.Naam} via uitgeverij {boek.Uitgeverij.Naam}");
                }
                else
                {
                    Console.WriteLine($"Boek met isbn {isbn} zit niet in database.");
                } 
            }
            Console.WriteLine();
        }

        static void Verwijder()
        {
            Console.WriteLine("Wat wil u verwijderen?");
            Console.WriteLine("1) Auteur");
            Console.WriteLine("2) Uitgeverij");
            Console.WriteLine("3) Boek");
            Console.WriteLine();
            int keuze = int.Parse(Console.ReadLine());

            using (var context = new BoekContext())
            {
                Console.WriteLine("Geef id in van record die u wil verwijderen.");
                GeefWeer(keuze);
                int id = int.Parse(Console.ReadLine());

                if (keuze == 1)
                {
                    if (!context.Auteur.Any(a => a.AuteurId == id))
                    {
                        context.Auteur.Remove(context.Auteur.SingleOrDefault(a => a.AuteurId == id));
                    }
                    else
                    {
                        Console.WriteLine("Ongelidge id.");
                    }
                }
                else if (keuze == 2)
                {
                    if (!context.Uitgever.Any(u => u.UitgeverijId == id))
                    {
                        context.Uitgever.Remove(context.Uitgever.SingleOrDefault(u => u.UitgeverijId == id));
                    }
                    else
                    {
                        Console.WriteLine("Ongelidge id.");
                    }
                }
                else if (keuze == 3)
                {
                    if (!context.Boeken.Any(b => b.Id == id))
                    {
                        context.Boeken.Remove(context.Boeken.SingleOrDefault(b => b.Id == id));
                    }
                    else
                    {
                        Console.WriteLine("Ongelidge id.");
                    }
                }
                else
                {
                    Console.WriteLine("Ongeldige keuze");
                }
                context.SaveChanges();
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            string keuze;
            do
            {
                Console.WriteLine("Wat wilt u doen?");
                Console.WriteLine("1) Records toevoegen.");
                Console.WriteLine("2) Tabel lezen.");
                Console.WriteLine("3) Details van boeken lezen.");
                Console.WriteLine("4) Record verwijderen.");
                Console.WriteLine("9) Exit.");
                Console.WriteLine();
                keuze = Console.ReadLine();

                switch (keuze)
                {
                    case "1":
                        Console.WriteLine("Wat wil u toevoegen?");
                        Console.WriteLine("1) Auteur");
                        Console.WriteLine("2) Uitgeverij");
                        Console.WriteLine("3) Boek");
                        Console.WriteLine();
                        string keuze1 = Console.ReadLine();
                        do
                        {
                            AddRecord(int.Parse(keuze1));
                            Console.WriteLine("Nog een record toevoegen? y/n");
                            keuze = Console.ReadLine();
                        } while (keuze != "n");
                        break;
                    case "2":
                        Console.WriteLine("Welke tabel wil u zien?");
                        Console.WriteLine("1) Auteur");
                        Console.WriteLine("2) Uitgeverij");
                        Console.WriteLine("3) Boek");
                        Console.WriteLine();
                        int keuze2 = int.Parse(Console.ReadLine());
                        GeefWeer(keuze2);
                        break;
                    case "3":
                        BoekDetails();
                        break;
                    case "4":
                        do
                        {
                            Verwijder();
                            Console.WriteLine("Nog een record verwijderen? y/n");
                            keuze = Console.ReadLine();
                        } while (keuze != "n");
                        break;
                    default:
                        break;
                }

            } while (keuze != "9");
            Console.ReadLine();
        }
    }
}
