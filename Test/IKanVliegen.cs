using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    interface IKanVliegen
    {

        int VleugelSpan { get; }

        void Vlieg(int hoogte);
        void Vlieg();
    }
}
