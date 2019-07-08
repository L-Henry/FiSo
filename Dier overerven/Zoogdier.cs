using System;
using System.Collections.Generic;
using System.Text;

namespace Dier_overerven
{
    class Zoogdier : Dier
    {
        public Zoogdier(string geluid) : base(geluid)
        {
        }


        public override void MaakGeluid()
        {
            Console.WriteLine("Woo woo"); ;
        }

        public void Stap()
        {
            Console.WriteLine("Zoogdier stapt.");
        }

        public void Beval()
        {
            Console.WriteLine("Zoogdier bevalt.");
        }

    }
}
