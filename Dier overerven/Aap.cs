using System;
using System.Collections.Generic;
using System.Text;

namespace Dier_overerven
{
    class Aap : Zoogdier
    {

        public Aap(string geluid) : base(geluid)
        {
        }

        public Aap() : base("Oe oe aa aa")
        {
        }

        public override void MaakGeluid()
        {
            Console.WriteLine("Oe oe aa aa"); ;
        }


    }
}
