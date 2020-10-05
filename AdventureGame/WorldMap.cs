using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AdventureGame
{
    class WorldMap
    {
        static int width = 50;
        static int height = 25; 

        char[,] matris = new char[height, width];

        public void AddWalls()
        {
            for (int y = 0; y < height; y++)
            {
                // matris[y, 0] = '║';  // kod till väggen till vänster 
                matris[y, 0] = '║';  // kod till väggen till vänster
                matris[y, width - 1] = '║'; // kod till väggen till höger

                for (int x = 0; x < width; x++)
                {

                    matris[0, x] = '═'; // kod till "golvet"!
                    matris[height - 1, x] = '═'; // kod till "golvet"!
                    matris[24, 49] = '╝';
                    matris[0, 49] = '╗';
                    matris[0, 0] = '╔';
                    matris[24, 0] = '╚';

                    Console.Write(matris[y, x]); // Skriver ut ramen. 

                }

                Console.WriteLine();
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
