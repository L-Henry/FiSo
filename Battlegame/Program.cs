using System;

namespace Battlegame
{
    class Program
    {
        static void Main(string[] args)
        {
            Sword sword1 = new Sword(20, 40);
            Dagger dagger1 = new Dagger(10, 100);

            Soldier soldier1 = new Soldier("een",dagger1, 1400);
            Soldier soldier2 = new Soldier("twee", sword1, 2000);
            Mage mage1 = new Mage("Merlijn", 1000);

            BattleArena arena = new BattleArena(mage1, soldier1);
            arena.StartFight();


            Console.ReadLine();

        }
    }
}
