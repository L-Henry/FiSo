using System;
using System.Collections.Generic;
using System.Text;

namespace Battlegame
{
    class Dagger : BaseWeapon
    {
        public Dagger(int min, int max) : base(min, max)
        {
            CritChance = 20;
            CritMultiplier = 3;
            DamageType = "melee";
        }



    }
}
