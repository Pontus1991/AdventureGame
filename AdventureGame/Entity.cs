using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    abstract class Entity
    {
        //HEJ
        public int HP { get; set; }
        public int Mana { get; set; }
        public int Strength { get; set; }



        public Entity(int hp, int mana, int strength)
        {
            HP = hp;
            Mana = mana;
            Strength = strength;           
        }

        public abstract void Kick();

    }
}
