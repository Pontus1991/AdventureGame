using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class WorldMap
    {
        public void AddWalls()
        {
            int width = 50;
            int height = 25;

            char[,] matris = new char[height, width];
            matris[0, width - 1] = '╗';
            matris[0, 0] = '╔';

            matris[height - 1, 0] = '╚';



            Console.WriteLine(matris[0, 4]);

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
    }
}
