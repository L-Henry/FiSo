using System;
using System.Collections.Generic;
using System.Text;

namespace Dier_overerven
{
    class Gorilla : Aap
    {
        public Gorilla(string geluid) : base(geluid)
        {
        }

        public Gorilla() : base("Brul")
        {
        }



        public override void MaakGeluid()
        {
            Console.WriteLine("Gorilla oe oe aa aa"); ;
        }

        public void Slaan()
        {
            Console.WriteLine("Gorilla slaat met vuisten.");
        }

    }
}
