using System;
using System.Collections.Generic;
using System.Text;

namespace Battlegame
{
    public interface IWeapon
    {
        int MinAttack { get; set; }
        int MaxAttack { get; set; }
        int CritChance { get; set; }
        double CritMultiplier { get; set; }
        string DamageType { get; set; }



    }
}
