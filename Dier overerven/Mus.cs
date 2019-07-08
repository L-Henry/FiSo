using System;
using System.Collections.Generic;
using System.Text;

namespace Dier_overerven
{
    class Mus : Vogel
    {
        public Mus(string geluid) : base(geluid)
        {
            GeheimeFunctionaliteitVoorAlleDieren();
        }


        public override void MaakGeluid()
        {
            Console.WriteLine($"De mus zingt {Geluid}."); ;
        }



    }
}
