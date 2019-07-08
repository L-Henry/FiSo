using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figuren
{
    class Figuur
    {
        public Point Middelpunt { get; set; }
        public Point Coordinaat { get; set; }



        public Figuur(Point coordinaat)
        {
            Coordinaat = coordinaat;
        }


        internal BerekenAfstand(Point Middelpunt)
        {

        }

        internal BerekenAfstand(Figuur figuur)
        {

        }

    }
}
