using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class Items
    {
        public string Sunglasses { get; set; }
        public string Sword { get; set; }
        public string Shield { get; set; }
        public string Egg { get; set; }
        public string Shuriken { get; set; }
        public string ManaPotion { get; set; }
        public string HealthPotion { get; set; }

        public Player(string sunglasses, string sword, string shield, string egg, string shuriken, string manapotion, string healthpotion) //: base(10, 10, 10, 10, 10, 10, 10, 10)
        {
            Sunglasses = sunglasses;
            Sword = sword;
            Shield = shield;
            Egg = egg;
            Shuriken = shuriken;
            ManaPotion = manapotion;
            HealthPotion = healthpotion;
        }

    }
}
