using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huis_en_kamers
{
    class Meubel
    {

        public string Naam { get; set;  }

        public Meubel(string type)
        {
            Naam = type;
        }
    }
}
