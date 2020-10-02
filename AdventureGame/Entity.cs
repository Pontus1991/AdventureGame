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

        public int Agility { get; set; }

        public Entity(int hp, int mana, int strength, int agility)
        {
            HP = hp; 
            Mana = mana;
            Strength = strength; // Ska inverka på förnågor. 
            Agility = agility; // Agility är 0 i början men hittar man solglasögonen så blir den 10. Blir den 10 så syns alla items på kartan.
        }

        public abstract void Kick();

    }
}
