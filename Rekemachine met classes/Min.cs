﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekemachine_met_classes
{
    class Min : IOperator
    {
        public Min()
        {
        }

        public double Bereken(double getal1, double getal2)
        {
            return getal1 - getal2;
        }

    }
}
