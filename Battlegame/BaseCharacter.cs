using System;
using System.Collections.Generic;
using System.Text;

namespace Battlegame
{
    public abstract class BaseCharacter
    {
        public string Naam { get; set; }
        public int MaxHealth { get; set; }
        public int Healthpoints { get; set; }
        public bool IsAlive
        {
            get
            {
                if (Healthpoints > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        } 


        public BaseCharacter(string naam, int health)
        {
            Naam = naam;
            MaxHealth = health;
            Healthpoints = health;
        }

        public void ReceieveDamage(int hit)
        {
            Healthpoints -= hit;
            //Console.WriteLine($"{Naam} is geraakt met {hit} damage en heeft nog {Healthpoints} over.");
        }

        public abstract int Attack();


    }
}
