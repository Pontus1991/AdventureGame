using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    abstract class Entity
    {
        public int HP { get; set; }
        public int Mana { get; set; }
        public int Strength { get; set; }

       

        public Entity(int hp, int mana, int strength)
        {
            HP = hp; 
            Mana = mana;
            Strength = strength; // Ska inverka på förnågor. 
            
        }

        public abstract void Kick();

    }
}
