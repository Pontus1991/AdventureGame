﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AdventureGame
{
    class Player : Monster
    {
      
        public List<Item> PlayerBag { get; set; }

        // Konstruktor
        public Player(int hp, int mana, int strength, int agility) : base(hp, mana, strength, agility)
        {
            PlayerBag = new List<Item>();
            var shield = new Shield();

            PlayerBag.Add(shield);
            
        }

        public override void Kick()
        {

            if (Strength <= 5)
            {
                int kick = rnd.Next(1, 7);
                HP -= kick;
                Console.WriteLine($"A kick flies through the air!\n {kick} in damage, {HP} left!");
            }
            else if (Strength >= 5)
            {
                int kick = rnd.Next(3, 9);
                HP -= kick;
                Console.WriteLine($"A kick flies through the air!\n {kick} in damage, {HP} left!");
            }
        }
        public void UseSword()
        { 
            //  Fixar senare. if
            //  Objektet.HP -= 5?
            // If player press "space" så anropas denna metod och då gör man x skada. 
            // Fiendens hp minskar. 
        }

        //public void UseShield()
        //{

        //    if (PlayerBag.Contains(PlayerBag[2]))
        //    {
        //        Console.WriteLine($"Du blockar och tar 2 mindre i skada.");

        //    }
        //    //Fixar senare. if
        //    // Player.HP +=2;
        //}


        

        public void ExtraDamageLowHp() // Gör mer skada när man har under 30 % hp ?
        {
            // Hur impleneterar vi att den gör mer hp..
            // If playerhp is less than 30
           // Console.WriteLine("Dina styrka ökar med med...");

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
    }
}
