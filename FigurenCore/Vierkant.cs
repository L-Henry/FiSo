using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FigurenCore
{
    public class Vierkant : Figuur
    {

        public Vierkant(Point middelpunt, double zijde) : base(middelpunt)
        {
            Zijde = zijde;
        }

        public double Zijde { get; set; }

        public override double BerekenOmtrek()
        {
            return Zijde * 4;
        }

        public override double BerekenOppervlakte()
        {
            return Zijde * Zijde;
        }

    }
}
