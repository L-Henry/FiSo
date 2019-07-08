using System;
using System.Collections.Generic;
using System.Text;

namespace Battlegame
{
    public abstract class BaseWeapon : IWeapon
    {
        public int MinAttack { get; set; }
        public int MaxAttack { get; set; }
        public int CritChance { get; set; }
        public double CritMultiplier { get; set; }
        public string DamageType { get; set; }


        public BaseWeapon(int min, int max)
        {
            MinAttack = min;
            MaxAttack = max;
        }

    }
}
