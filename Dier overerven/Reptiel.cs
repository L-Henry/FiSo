using System;
using System.Collections.Generic;
using System.Text;

namespace Dier_overerven
{
    class Reptiel : Dier
    {
        public Reptiel() : base("graa")
        {
        }


        public override void MaakGeluid()
        {
            Console.WriteLine("graa"); ;
        }

        public void Kruip()
        {
            Console.WriteLine("Reptiel kruipt.");
        }

        public void LegEi()
        {
            Console.WriteLine("Reptiel legt ei.");
        }


    }
}
