using System;
using System.Collections.Generic;
using System.Text;

namespace Battlegame
{
    public interface ISpells
    {
        int MinAttack { get; set; }
        int MaxAttack { get; set; }
        string DamageType { get; set; }

    }
}
