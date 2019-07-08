using System;
using System.Collections.Generic;
using System.Text;

namespace Dier_overerven
{
    class Neusaap : Aap
    {
        public Neusaap(string geluid) : base(geluid)
        {
        }

        public Neusaap() : base("Brul")
        {
        }

        public override void MaakGeluid()
        {
            Console.WriteLine("Neusaap oe oe aa aa");
        }
    }
}
