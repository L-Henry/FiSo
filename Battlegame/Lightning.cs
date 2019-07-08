using System;
using System.Collections.Generic;
using System.Text;

namespace Battlegame
{
    class Lightning : BaseSpell
    {

        public Lightning(int min, int max) : base(min, max)
        {
            DamageType = "lightning";
        }

    }
}
