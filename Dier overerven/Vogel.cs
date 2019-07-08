using System;
using System.Collections.Generic;
using System.Text;

namespace Dier_overerven
{
    public class Vogel : Dier
    {

        public Vogel() : this("Tsjirp")
        {
        }

        public Vogel(string geluid) : base(geluid)
        {
        }

        public override void MaakGeluid()
        {
            Console.WriteLine($"De vogel fluit {Geluid}."); ;
        }

        public void Vlieg()
        {
            Console.WriteLine("Fladder Fladder");
        }


    }
}
