using System;
using System.Collections.Generic;
using System.Text;

namespace Eventss
{
    class OnCalculationEventsArgs
    {
        public double Getal1 { get; private set; }
        public double Getal2 { get; private set; }

        public OnCalculationEventsArgs(double getal1, double getal2)
        {
            Getal1 = getal1;
            Getal2 = getal2;
        }

    }
}
