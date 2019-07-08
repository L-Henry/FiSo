using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FigurenCore
{
    public abstract class Figuur
    {
        public Point Middelpunt { get; set; }

        

        public Figuur(Point middelpunt)
        {
            Middelpunt = middelpunt;
        }

        internal double BerekenAfstand(Point coordinaat)
        {
            double x = coordinaat.X - Middelpunt.X;
            double y = coordinaat.Y - Middelpunt.Y;
            double afstand = Math.Pow(x, 2) + Math.Pow(y, 2);
            return Math.Sqrt(afstand);
        }

        internal double BerekenAfstand(Figuur figuur)
        {
            return BerekenAfstand(figuur.Middelpunt);
        }

        public abstract double BerekenOmtrek();
        

        public abstract double BerekenOppervlakte();
        

    }
}
