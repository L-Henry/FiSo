using System;
using System.Collections.Generic;
using System.Text;

namespace ForumUsers
{
    public abstract class User : Persoon, IRole
    {
        public string RoleName { get; set; }
        public string EmailAdres { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; } = true;
        
        public User(string voornaam, string achternaam, string adres, DateTime datum, string role, string email, string userName)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            Adres = adres;
            GeboorteDatum = datum;

            RoleName = role;
            EmailAdres = email;
            UserName = userName;
        }

        public virtual void Details()
        {
            Console.WriteLine($"{UserName} is {RoleName}, emailadres: {EmailAdres}. Actief? {IsActive}");
            Console.WriteLine($"Persoonlijke gegevens: {Voornaam}, {BerekenLeeftijd()} jaar oud.");
        }


    }
}
