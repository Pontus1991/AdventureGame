using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AdventureGame
{
    class Player : Monster
    {
        public List<string> PlayerBag { get; set; }

        public Player(int hp, int mana, int strength, int endurance, int luck, int agility, int patience, int charisma, List<string> playerBag) :base(hp, mana, strength, endurance, luck, agility, patience, charisma)
        {
            PlayerBag = playerBag;
        }
    }
}
