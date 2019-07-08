using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekemachine_met_classes
{
    public class Calc
    {

        public Calc()
        {
        }

        public double Berekening(double getal1, double getal2, IOperator teken)
        {
            return teken.Bereken(getal1, getal2);
        }



        internal double Som(double getal1, double getal2)
        {
            return getal1 + getal2;
        }
        internal double Verschil(double getal1, double getal2)
        {
            return getal1 - getal2;
        }
        internal double Product(double getal1, double getal2)
        {
            return getal1 * getal2;
        }
        internal double Quotient(double getal1, double getal2)
        {
            return getal1 / getal2;
        }
        internal double Modulo(double getal1, double getal2)
        {
            return getal1 % getal2;
        }


    }
}
