using System;

namespace ForumUsers
{
    class Program
    {
        static void Main(string[] args)
        {

            Admin admin1 = new Admin("Adam", "Albrecht", "Adres 1", new DateTime(2000,6,6), "Admin", "admin@admin", "admin1", true);
            ReadUser reader1 = new ReadUser("Brecht", "Bakens", "Adres 2", new DateTime(1990, 6, 6), "ReadUser", "reader1@forum", "reader1", true);
            WriteUser writer1 = new WriteUser("Brecht", "Bakens", "Adres 2", new DateTime(1990, 7, 15), "WriteUser", "reader1@forum", "writer1", true);

            Console.WriteLine(admin1.BerekenLeeftijd());
            Console.WriteLine(reader1.BerekenLeeftijd());
            Console.WriteLine(writer1.BerekenLeeftijd());

            admin1.Details();
            reader1.Details();
            writer1.Details();

            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(reader1.GeboorteDatum.Month);
            Console.WriteLine(writer1.GeboorteDatum.Month);

            admin1.BanUser(admin1);
            admin1.BanUser(reader1);
        }
    }
}
