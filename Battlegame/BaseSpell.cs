using System;
using System.Collections.Generic;
using System.Text;

namespace Battlegame
{
    public abstract class BaseSpell : ISpells
    {
        public int MinAttack { get; set; }
        public int MaxAttack { get; set; }
        public string DamageType { get; set; }

        public BaseSpell(int min, int max)
        {
            MinAttack = min;
            MaxAttack = max;
        }

    }
}
