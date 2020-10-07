using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;

namespace AdventureGame
{
    class WorldMap
    {
        bool gameState = false;
        const char manaPotion = 'M';
        const char Player = 'X'; // Character to write on-screen. //
        int n = 25, o = 25; // Contains current cursor position.
        private const int width = 50;
        private const int height = 25; // Vi diskuterade access modifers men eftersom det har ändrats så mycket i vår kod.
        // Vi ville ha protected å¨våra properties i Enteti men insåg att det inte gick eftersom Worldmap (game) inte ärver ifrån entity. 

        char[,] matris = new char[height, width];

        

        public void Display(int x, int y, string s) // Om man vill sätta ut något speciellt och på vilken position????
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }

        public void WritePlayer(char toWrite, int x = 0, int y = 0)
        // x och y är storleken på rutan 
        {
            try
            {
                if (x >= 0 && y >= 0) // 0-based
                {
                    Console.SetCursorPosition(x, y); // Vart ska man spawna.... 
                    Console.Write(toWrite); // Denna gör så att spelaren syns. 
                }
            }
            catch (Exception)
            {
            }
        }
        public void WriteItem(char toWrite, int x = 0, int y = 0)
        // x och y är storleken på rutan 
        {
            if (x >= 0 && y >= 0) // 0-based
            {
                Console.SetCursorPosition(x, y); // Vart ska man spawna.... 
                Console.Write(toWrite); // Denna gör så att spelaren syns. 
            }
            else
            {
            Console.WriteLine("HEJ DET FUNKAR");
            return;
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
            }
        }

        public void AddWalls()
        {
           
            // Rita ut varelser etc som en char i arrayen....
            for (int y = 0; y < height; y++)
            {
                // matris[y, 0] = '║';  // kod till väggen till vänster 
                matris[y, 0] = '║';  // kod till väggen till vänster
                matris[y, width - 1] = '║'; // kod till väggen till höger

                for (int x = 0; x < width; x++)
                {
                    matris[0, x] = '═'; // kod till "taket"!
                    matris[height - 1, x] = '═'; // kod till "golvet"!
                    matris[24, 49] = '╝';
                    matris[0, 49] = '╗';
                    matris[0, 0] = '╔';
                    matris[24, 0] = '╚';
                }
            }       
        }
        
        public void RunGameLoop() // Kör spelet!!!!
        {
           
            //gameState = true;
            ManaPot manaPot = new ManaPot("ManaPotion", 50, "Mana");
            
            Player spelare = new Player(100, 100, 10);
            Shield shield = new Shield("Shield", 20, "HP");


            spelare.PlayerBag.Add(shield);
            if (spelare.PlayerBag.Contains(shield))
            {
                spelare.HP += shield.AttributeModifier;
                //Console.WriteLine(spelare.HP);
            }
          
            else
            {
                Console.WriteLine("DET FUNKAR INTE!!!");
            }

            //spelare.HP += 20;
            //Console.WriteLine(spelare.HP + shield.AttributeModifier);
            //if (Player == 'X')
            //{
            //    spelare.HP -= 20;
            //    Console.WriteLine(spelare.HP);


            //}
            //WriteItem('M', 25, 25);
            while (true)
            {
                //Console.ReadKey();
                // Skriv ut spelaren
                //ConsoleKeyInfo keyinfo = Console.ReadKey(true); // Med dessa två så måste man trycka pil två gånger
                //ConsoleKey key = keyinfo.Key; // Med dessa två så måste man trycka pil två gånger
                if(Console.KeyAvailable)
                {
                  
                    //Console.ReadKey();
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
                

               


                //else
                //{
                //    System.Threading.Thread.Sleep(100);
                //}

            }

            
          
        }

        //public void Draw()
        //{
        //    for (int y = 0; y < height; y++)
        //    {
        //        for (int x = 0; x < width; x++)
        //        {
        //            Console.Write(matris[y, x]); // Skriver ut ramen.
        //        }
        //    }
        //}

        //public bool IsPositionWalkable(int x, int y) // Is open for the player to walk to. 
        //{
        //    // Check bounds first. 
        //    if (x < 0 || y < 0 || x >= width || y >= height)
        //    {
        //        return false;
        //    }

        //    // Check if the grid is a walkable tile. 
        //    return matris[y, x] == ' ' || matris[y, x] == 'X'; // X är goal för playern. 
        //}


    }
}
