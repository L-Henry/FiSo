using System;

namespace Woordenboek
{
    class Program
    {
        static void Main(string[] args)
        {
            Woordenboek<int, string> boek = new Woordenboek<int, string>();
            Woordenboek2<int, string> boek2 = new Woordenboek2<int, string>();

            boek.Add(new KeyValuePaar<int, string>(99, "negen negen"));
            boek.Add(new KeyValuePaar<int, string>(9, "negen"));
            boek.Add(new KeyValuePaar<int, string>(5, "vijf"));
            boek.Add(6, "zes");

            boek2.Add(new KeyValuePaar<int, string>(99, "negen negen"));
            boek2.Add(new KeyValuePaar<int, string>(9, "negen"));
            boek2.Add(new KeyValuePaar<int, string>(5, "vijf"));
            boek2.Add(6, "zes");

            Console.WriteLine("Lengte methode 1" + boek.Boek.Length);
            Console.WriteLine("Lengte methode 2" + boek2.Boek.Count());
            Console.WriteLine();
            Console.WriteLine("Methode 1");
            for (int i = 0; i < boek.Boek.Length; i++)
            {
                Console.WriteLine(boek.Boek[i].Key + " " + boek.Boek[i].Value);
            }
            Console.WriteLine();
            Console.WriteLine("Methode 2");
            for (int i = 0; i < boek2.Boek.Count(); i++)
            {
                Console.WriteLine(boek2.Boek.Get(i).Key + " " + boek2.Boek.Get(i).Value);
            }
            Console.WriteLine();

            Console.WriteLine("Get van methode 1: " + boek.Get(9));
            Console.WriteLine("Get van methode 2: " + boek2.Get(9));
            Console.WriteLine();

            boek.Remove(9);
            boek2.Remove(9);
            Console.WriteLine("Remove van methode 1");
            for (int i = 0; i < boek.Boek.Length; i++)
            {
                Console.WriteLine(boek.Boek[i].Key + " " + boek.Boek[i].Value);
            }
            Console.WriteLine();
            Console.WriteLine("Remove van methode 2");
            for (int i = 0; i < boek2.Boek.Count(); i++)
            {
                Console.WriteLine(boek2.Boek.Get(i).Key + " " + boek2.Boek.Get(i).Value);
            }
            Console.WriteLine();
        }
    }
}
