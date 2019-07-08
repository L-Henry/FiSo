using System;
using System.Collections.Generic;
using System.Text;

namespace Static_vliegtuig
{
    internal static class Tanktools
    {

        internal static void TankVol(Vliegtuig vliegtuig)
        {
            while (vliegtuig.Brandstof < vliegtuig.MaxBrandstof)
            {
                vliegtuig.Brandstof++;
            }
        }

    }
}
