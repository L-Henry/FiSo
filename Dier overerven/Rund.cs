using System;
using System.Collections.Generic;
using System.Text;

namespace Dier_overerven
{
    class Rund : Zoogdier
    {
        public Rund(string geluid) : base(geluid)
        {
        }

        public override void MaakGeluid()
        {
            Console.WriteLine("Mooooo"); ;
        }

    }
}
