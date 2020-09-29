using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class Monster
    {
        public int HP { get; set; }
        public int Mana { get; set; }
        public int Strength { get; set; }
        public int Endurance { get; set; }
        public int Luck { get; set; }
        public int Agility { get; set; }
        public int Patience { get; set; }
        public int Charisma { get; set; }

        public Monster(int hp, int mana, int strength, int endurance, int luck, int agility, int patience, int charisma)
        {
            HP = hp;
            Mana = mana;
            Strength = strength;
            Endurance = endurance;
            Luck = luck;
            Agility = agility;
            Patience = patience;
            Charisma = charisma;
        }



    }
}
