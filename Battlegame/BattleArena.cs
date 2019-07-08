using System;
using System.Collections.Generic;
using System.Text;

namespace Battlegame
{
    class BattleArena
    {
        public BaseCharacter[] Soldiers { get; set; }

        public BattleArena(BaseCharacter soldier1, BaseCharacter soldier2)
        {
            Soldiers = new BaseCharacter[2];
            Soldiers[0] = soldier1;
            Soldiers[1] = soldier2;

        }

        public void StartFight()
        {
            while (Soldiers[0].IsAlive && Soldiers[1].IsAlive)
            {
                int hit = Soldiers[1].Attack();
                Soldiers[0].ReceieveDamage(hit);
                if (Soldiers[1] is Mage)
                {
                    Mage tempMage = Soldiers[1] as Mage;
                    Console.WriteLine($"{Soldiers[0].Naam} is geraakt met {hit} {tempMage.Spells[tempMage.AttackType].DamageType} damage en heeft nog {Soldiers[0].Healthpoints} over.");
                }
                else
                {
                    Soldier tempSoldier = Soldiers[1] as Soldier;
                    Console.WriteLine($"{Soldiers[0].Naam} is geraakt met {hit} {tempSoldier.Weapon.DamageType} damage en heeft nog {Soldiers[0].Healthpoints} over.");
                }
                if (Soldiers[0].IsAlive)
                {
                    hit = Soldiers[0].Attack();
                    Soldiers[1].ReceieveDamage(hit);
                    if (Soldiers[0] is Mage)
                    {
                        Mage tempMage = Soldiers[0] as Mage;
                        Console.WriteLine($"{Soldiers[1].Naam} is geraakt met {hit} {tempMage.Spells[tempMage.AttackType].DamageType} damage en heeft nog {Soldiers[1].Healthpoints} over.");
                    }
                    else
                    {
                        Soldier tempSoldier = Soldiers[0] as Soldier;
                        Console.WriteLine($"{Soldiers[1].Naam} is geraakt met {hit} {tempSoldier.Weapon.DamageType} damage en heeft nog {Soldiers[1].Healthpoints} over.");
                    }
                }
                else
                {
                    break;
                }
            }
            if (Soldiers[0].Healthpoints > Soldiers[1].Healthpoints)
            {
                Console.WriteLine($"{Soldiers[0].Naam} is gewonnen.");
            }
            else
            {
                Console.WriteLine($"{Soldiers[1].Naam} is gewonnen.");

            }
        }


    }
}
