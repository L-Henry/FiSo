using System;
using System.Collections.Generic;
using System.Text;

namespace Dier_overerven
{
    class Vis : Dier
    {
        public Vis() : base("bloop bloop")
        {
        }


        public override void MaakGeluid()
        {
            Console.WriteLine("Bloop bloop");
        }

        public void Zwem()
        {
            Console.WriteLine("Vis zwemt.");
        }
    }
}
