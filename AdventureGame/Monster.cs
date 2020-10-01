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
        Random rnd = new Random();

        public void Kick()
        {
            //HEJ
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
       
        public void Psyche() // Psyka ut på nåt sätt med charisma så player måste vänta (stå över en omgång). På så sätt kan monster göra 2 "moves". 
        {
            if (Charisma > Patience)
            {
               //entity loses turn.
            }
            else if (Charisma < Patience)
            {
                Console.WriteLine("You stand there looking as stupid as your feeble attempt!"); //entity loses turn
            }

        }
        public void Scream()
        {
            if (Endurance > Strength)
            {
                //Entity drops random item and loses a turn.
            }
            else if (Endurance < Strength)
            {
                //Entity Gets one extra turn.
            }
        }

        public void LäggDot() // Lägg en dot som gör skada 3 "varv" Inte bleed utan något warlockaktigt. 
        {
            //Kostar mana, gör 1 i skada per turn, och slutar inte verka förrens Playern besegrar fienden.
        }



    }
}
