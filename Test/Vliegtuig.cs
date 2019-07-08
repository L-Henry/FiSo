using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Vliegtuig : IKanVliegen
    {
        public int VleugelSpan { get; set; }

        public void Vlieg(int hoogte)
        {
        }

        public void Vlieg()
        {
        }

        public void Vlieg(int snelheid, int hoogte)
        {
        }

    }
}
