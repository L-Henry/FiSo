using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FigurenCore
{
    public class Trapezium : Figuur
    {

        public int Lange { get; set; }
        public int Korte { get; set; }
        public int Hoogte { get; set; }
        public int Zijde { get; set; }


        public Trapezium(Point middelpunt, int zijde, int hoogte, int korte, int lange) : base(middelpunt)
        {
            Zijde = zijde;
            Korte = korte;
            Lange = lange;
            Hoogte = hoogte;
        }

        public override double BerekenOmtrek()
        {
            return 2 * Zijde + Lange + Korte;
        }

        public override double BerekenOppervlakte()
        {
            return (Lange + Korte) / 2 * Hoogte;
        }
    }
}
