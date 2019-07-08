using System;
using System.Collections.Generic;
using System.Text;

namespace Battlegame
{
    class Fire : BaseSpell
    {

        public Fire(int min, int max) : base(min, max)
        {
            DamageType = "fire";
        }

    }
}
