using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace IRacer
{
    interface IRacer
    {
        Point Positie { get; set; }
        int PositieIncrementer { get; }
        string NaamBestuurder { get; set; }

        bool Gewonnen { get; set; }
        Banden Banden { get; set; }


        void GaPositieNaarVoor(double bochten);



    }
}
