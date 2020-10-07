using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{


    class Monster : Entity
    {
        public Monster(int hp, int mana, int strength) : base(hp, mana, strength)
        {           
        }
        public Random rnd = new Random();

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
       
        public void LäggDot() // Lägg en dot som gör skada 3 "varv" Inte bleed utan något warlockaktigt. 
        {
            if (Mana >= 10)
            {
                Mana -= 20;
                //Vet ej i hur vi implemeneterar att LäggDot(); Skall göra 1 i skada per "turn".
            }   //Kostar mana, gör 1 i skada per turn, och slutar inte verka förrens Playern besegrar fienden.

        }



    }
}
