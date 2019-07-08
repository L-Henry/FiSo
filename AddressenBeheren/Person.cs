using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressenBeheren
{
    public class Person
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public int Id { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public int Leeftijd
        {
            get
            {
                int age = 0;
                age = DateTime.Now.Year - GeboorteDatum.Year;
                if (DateTime.Now.DayOfYear < GeboorteDatum.DayOfYear)
                {
                    age -= 1;
                }
                return age;
            }
        }
        public Color Kleur { get; set; }

    }
}
