using System;
using System.Collections.Generic;
using System.Text;

namespace Battlegame
{
    public class Soldier : BaseCharacter
    {

        public IWeapon Weapon { get; set; }


        public Soldier(string naam, IWeapon weapon, int health) : base(naam, health)
        {
            Weapon = weapon;
        }

        public override int Attack()
        {
            double rInt;
            Random critRandom = new Random();
            int critChance = critRandom.Next(0, 100 - Weapon.CritChance);

            if (critChance > 20)
            {
                Random r = new Random();
                rInt = r.Next(Weapon.MinAttack, Weapon.MaxAttack + 1);
            }
            else
            {
                Random r = new Random();
                rInt = r.Next(Weapon.MinAttack, Weapon.MaxAttack + 1);
                rInt *= Weapon.CritMultiplier;
                Console.Write("Cricital hit! ");
            }
            return (int)rInt;
            
        }


    }
}
