using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drankautomaat
{
    class DrankStock
    {
        public string NaamDrank { get; set; }
        public decimal Prijs { get; set; }
        public int Aantal { get; set; }

        public DrankStock(string naam, decimal prijs, int aantal)
        {
            NaamDrank = naam;
            Prijs = prijs;
            Aantal = aantal;
        }

    }
}
