using System;
using System.Collections.Generic;
using System.Text;

namespace Battlegame
{
    class Ice : BaseSpell
    {


        public Ice(int min, int max) : base(min, max)
        {
            DamageType = "ice";
        }

    }
}
