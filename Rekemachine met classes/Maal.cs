using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekemachine_met_classes
{
    class Maal : IOperator
    {

        public Maal()
        {
        }

        public double Bereken(double getal1, double getal2)
        {
            return getal1 * getal2;
        }
    }
}
