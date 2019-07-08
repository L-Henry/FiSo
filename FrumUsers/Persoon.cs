using System;
using System.Collections.Generic;
using System.Text;

namespace ForumUsers
{
    public abstract class Persoon
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Adres { get; set; }
        public DateTime GeboorteDatum { get; set; }



        public double BerekenLeeftijd()
        {
            int jaren = DateTime.Now.Year - GeboorteDatum.Year;
            if (DateTime.Now.Month < GeboorteDatum.Month || (DateTime.Now.Month == GeboorteDatum.Month && DateTime.Now.Day > GeboorteDatum.Day))
            {
                jaren--;
            }
            return jaren + 1;
        }

    }




}
