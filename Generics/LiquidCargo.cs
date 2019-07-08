using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class LiquidCargo : ILiquidCargo
    {
        public int Liters { get; set; }
        public double Viscosity { get; set; }

        public int Gewicht()
        {
            return Liters * 2;
        }

        public override string ToString()
        {
            return "Aantal liters " + Liters;
        }

    }
}
