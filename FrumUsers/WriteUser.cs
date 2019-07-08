using System;
using System.Collections.Generic;
using System.Text;

namespace ForumUsers
{
    public class WriteUser : User
    {
        public WriteUser(string voornaam, string achternaam, string adres, DateTime datum, string rol, string email, string userName) 
            : base(voornaam, achternaam, adres, datum, rol, email, userName)
        {

        }

        public void ReadForum()
        {
            Console.WriteLine($"Lees");
        }

        public void WriteForum()
        {
            Console.WriteLine($"Schrijf");
        }

    }
}
