using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FigurenCore
{
    public class Cirkel : Figuur
    {
        public Cirkel(Point middelpunt, double straal) : base(middelpunt)
        {
            Straal = straal;
        }

        public double Straal { get; set; }

        public override double BerekenOmtrek()
        {
            return 2 * Math.PI * Straal;
        }

        public override double BerekenOppervlakte()
        {
            return Math.PI * Straal * Straal;
        }

    }
}
