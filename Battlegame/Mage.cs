using System;
using System.Collections.Generic;
using System.Text;

namespace Battlegame
{
    public class Mage : BaseCharacter
    {

        public ISpells[] Spells { get; set; }
        public int AttackType { get; set; }

        public Mage(string naam, int health) : base(naam, health)
        {
            Spells = new ISpells[3];
            Spells[0] = new Ice(20, 40);
            Spells[1] = new Fire(30, 60);
            Spells[2] = new Lightning(125, 175);
            AttackType = 0;
        }

        public override int Attack()
        {
            int rInt2;
            if (Healthpoints > MaxHealth / 2)
            {
                Random r = new Random();
                AttackType = r.Next(0, Spells.Length - 1);
                Random r2 = new Random();
                rInt2 = r2.Next(Spells[AttackType].MinAttack, Spells[AttackType].MaxAttack + 1);
            }
            else if (Healthpoints > MaxHealth / 10)
            {
                AttackType = 2;
                Random r2 = new Random();
                rInt2 = r2.Next(Spells[AttackType].MinAttack, Spells[AttackType].MaxAttack + 1);
            }
            else
            {
                AttackType = 2;
                Random r2 = new Random();
                rInt2 = r2.Next(Spells[AttackType].MinAttack, Spells[AttackType].MaxAttack + 1);
                rInt2 *= 2;
                int absorb = rInt2 / 10;
                Healthpoints += absorb;
                Console.Write($"{Naam} heeft {absorb} health geabsorbeerd. ");
            }

            return rInt2;

        }
    }
}
