using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekemachine_met_classes
{
    class Sqrt : IOperator
    {
        public Sqrt()
        {
        }

        public double Bereken(double getal1, double getal2)
        {
            return Math.Pow(getal1, 1/getal2);
        }

    }
}
