using System;
using System.Collections.Generic;
using System.Text;

namespace Battlegame
{
    class Sword : BaseWeapon
    {
        public Sword(int min, int max) : base(min, max)
        {
            CritChance = 20;
            CritMultiplier = 1.5;
            DamageType = "melee";
        }


    }
}
