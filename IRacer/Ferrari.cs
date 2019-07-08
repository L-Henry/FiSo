using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace IRacer
{
    class Ferrari : IRacer
    {
        public Point Positie { get; set; }

        public int PositieIncrementer { get; }

        public string NaamBestuurder { get; set; }

        public bool Gewonnen { get; set; }

        public Banden Banden { get; set; }

        public Ferrari(Point positie, int posInc, string naam, Banden banden)
        {
            Positie = positie;
            PositieIncrementer = posInc;
            NaamBestuurder = naam;
            Banden = banden;
        }


        public void GaPositieNaarVoor(double bochten)
        {
            Positie = new Point(Positie.X, Positie.Y + PositieIncrementer * (int)Math.Ceiling(5 / bochten * Banden.Grip));
            Banden.Grip -= 0.01;
        }
    }
}
