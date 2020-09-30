using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AdventureGame
{
    class Player : Monster
    {
      
        public List<Items> PlayerBag { get; set; }

        // Konstruktor
        public Player(int hp, int mana, int strength, int endurance, int luck, int agility, int patience, int charisma, List<Items> playerBag) : base(hp, mana, strength, endurance, luck, agility, patience, charisma)
        {
            PlayerBag = playerBag;
        }

            // IF (player is same place as monster)
            // {
            //   “Monstret” kan med sin egenskap styrka=10 via förmågan “sparka” sänka spelarens
            //egenskap livsstyrka med 10 
            //  Console.WriteLine("playerhealt - 10");
            // }
            //     “Försäljaren” kan med sin egenskap karisma och pratgladhet använda förmågan
            //SalesPitch() och sänka spelarens tålamod till 0.
            // Console.WriteLine("Salespitch);
            //{

            //}
        

        public void UseSword()
        { 
        
        }

        public void UseShield()
        {

        }


        public void UseLaser() // 30 sec cooldown etc... 
        {

        }

        public void ExtraDamageLowHp() // Gör mer skada när man har under 30 % hp ?
        {

        }
    }
}
