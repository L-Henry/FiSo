using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class BoxCargo : ICargo
    {
        public int BoxAmount { get; set; }
        public double CubicMeters { get; set; }

        public BoxCargo()
        {

        }

        public int Gewicht()
        {
            return BoxAmount * 100;
        }

        public override string ToString()
        {
            return "Aantal dozen " + BoxAmount;
        }

    }
}
