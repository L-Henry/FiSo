using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Wagen : IKanRijden, IkKanRemmen
    {
        public string MerkNaam { get; set; }

        public Wagen()
        {

        }

        public void Rijden()
        {
        }

        public void Remmen()
        {
            throw new NotImplementedException();
        }
    }
}
