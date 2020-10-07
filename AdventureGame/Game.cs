using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;

namespace AdventureGame
{
    class Game
    {
        //bool gameState = false; //För att kontrollera spelet.
        const char manaPotion = 'M';
        const char Player = 'X'; 
        int n = 25, o = 25;
        private const int width = 50;
        private const int height = 25; // Vi diskuterade access modifers men eftersom det har ändrats så mycket i vår kod.
        // Vi ville ha protected på våra properties i Entities men insåg att det inte gick eftersom Worldmap (game) inte ärver ifrån entity. 
        char[,] matris = new char[height, width];

        

        public void Display(int x, int y, string s) //Om man vill sätta ut något speciellt och på vilken position????
        {                                           //Kommer inte ut vart vi placerar våra objekt.
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }

        public void WritePlayer(char toWrite, int x = 0, int y = 0)
        {
            try
            {
                if (x >= 0 && y >= 0) 
                {
                    Console.SetCursorPosition(x, y); // Vart ska man spawna.... 
                    Console.Write(toWrite); // Denna gör så att spelaren syns. 
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
  

        public void DrawWall()
        {
            AddWalls();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(matris[y, x]); // Skriver ut ramen. 
                }

                Console.WriteLine();
                //Gör att vi hoppar till ny rad efter varje iteration i x for loopen.
            }
        }

        public void AddWalls()
        {
           
            
            for (int y = 0; y < height; y++)
            {
                
                matris[y, 0] = '║'; 
                matris[y, width - 1] = '║';

                for (int x = 0; x < width; x++)
                {
                    matris[0, x] = '═';
                    matris[height - 1, x] = '═';
                    matris[24, 49] = '╝';
                    matris[0, 49] = '╗';
                    matris[0, 0] = '╔';
                    matris[24, 0] = '╚';
                }
            }       
        }
        
        public void RunGameLoop() // Kör spelet!!!!
        {
           
            //gameState = true; Skulle användas i samband med vår while-loop. Kom aldrig så långt att vi behövde en funktion för att stänga av spelet.
            ManaPot manaPot = new ManaPot("ManaPotion", 50, "Mana");           
            Player spelare = new Player(100, 100, 10);
            Shield shield = new Shield("Shield", 20, "HP");
            Sword sword = new Sword("Sword", 10, "Strength");
            HealPot healPot = new HealPot("HealPotion", 50, "HP");
            Shuriken shuriken = new Shuriken("Shuriken", 40, "DMG");
            Monster zombieKing = new Monster(70, 20, 4);
            Monster warlockKing = new Monster(40, 80, 2);
            warlockKing.LäggDot();
            Console.WriteLine(warlockKing.Mana);
    
            spelare.PlayerBag.Add(shield);
            if (spelare.PlayerBag.Contains(shield))
            {
                spelare.HP += shield.AttributeModifier;
               
            }
     
            while (true)
            {
                
                if(Console.KeyAvailable)
                {
                  
                    
                    var player = Console.ReadKey().Key;
                    WritePlayer(Player, n, o);
                    switch (player)
                    {
                        case ConsoleKey.DownArrow:
                            o++;
                            
                            break;
                        case ConsoleKey.UpArrow:
                            if (o > 0)
                            {
                                o--;
                            }
                            break;
                        case ConsoleKey.LeftArrow:

                            if (n > 0)
                            {
                                n--;
                            }
                            break;
                        case ConsoleKey.RightArrow:

                            n++;
                            break;
                    }
                }
                

               


             

            }

            
          
        }


    }
}
