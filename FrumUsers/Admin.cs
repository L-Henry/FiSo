using System;
using System.Collections.Generic;
using System.Text;

namespace ForumUsers
{
    public class Admin : User
    {
        public Admin(string voornaam, string achternaam, string adres, DateTime datum, string email, string userName) 
            : base(voornaam, achternaam, adres, datum, "Admin", email, userName)
        {

        }

        public void BanUser(User user)
        {
            if (user.RoleName != "Admin")
            {
                Console.WriteLine($"{user.UserName} is gebanned.");
                user.IsActive = false;
            }
            else
            {
                Console.WriteLine("Kan admin niet bannen.");
            }
        }


    }
}
