using System;
using System.Collections.Generic;
using System.Text;

namespace Dier_overerven
{
    class Merel : Vogel
    {
        public Merel()
        {
        }

        public Merel(string geluid) : base(geluid)
        {
        }


        public override void MaakGeluid()
        {
            Console.WriteLine($"De merel zingt {Geluid}"); ;
        }

    }
}
