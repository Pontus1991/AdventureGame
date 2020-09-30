using System;
using System.Collections.Generic;
using System.Text;

namespace Klass_till_spelkarta
{
    class Spelkarta
    {
        const int width = 30;
        const int height = 30;
        var gameWorld = new char[width, height];

            for (int x = 0; x < 29; x++)
            {
                gameWorld[x, 0] = '║';  // kod till väggen till vänster 
                gameWorld[28, x] = '═'; // kod till "golvet"

                for (int y = 0; y<height; y++)
                {
                    gameWorld[x, 29] = '║'; // kod till väggen till höger
                    gameWorld[0, y] = '═';  // kod till "taket"

                    gameWorld[0, 0] = '╔';
                    gameWorld[0, 29] = '╗';
                    gameWorld[28, 29] = '╝';
                    gameWorld[28, 0] = '╚';
                    
                    Console.Write(gameWorld[x, y]); // Skriver ut ramen. 
                }
                Console.WriteLine();
            }


            // Gjorde 2 st forloopar till en början  ╚ ╔

            //for (int i = 0; i < 10; i++)
            //{
            //    // i = x J = y
            //    //gameWorld[i, 9] = '║';
            //   // Console.Write(gameWorld[i, 0]);
            //    for (int j = 0; j < height; j++)
            //    {

            //        // gameWorld[9, i] = '║';
            //        //  gameWorld[j, width - 1] = '=';
            //        //  gameWorld[width - 1, i] = '=';
            //        //  gameWorld[i, width - 1] = '=';

            //        // Console.Write(gameWorld[i, j]);
            //        //Console.Write(gameWorld[j, i]);
            //       // Console.Write(gameWorld[i, j]);
            //    }
            //  //  Console.WriteLine();
            //}




            //char[,] twoDimensionArray = new char[15, 15];
            //twoDimensionArray[14, 14] = '╝';
            //twoDimensionArray[13, 14] = '║';
            //twoDimensionArray[12, 14] = '║';
            //twoDimensionArray[11, 14] = '║';
            //twoDimensionArray[10, 14] = '║';
            //twoDimensionArray[9, 14] = '║';
            //twoDimensionArray[8, 14] = '║';
            //twoDimensionArray[7, 14] = '║';
            //twoDimensionArray[6, 14] = '║';
            //twoDimensionArray[5, 14] = '║';
            //twoDimensionArray[4, 14] = '║';
            //twoDimensionArray[3, 14] = '║';
            //twoDimensionArray[2, 14] = '║';
            //twoDimensionArray[1, 14] = '║';
            //twoDimensionArray[0, 14] = '╗';

            //////////////////////////////////////////////////////////////

            //twoDimensionArray[14, 13] = '=';
            //twoDimensionArray[14, 12] = '=';
            //twoDimensionArray[14, 11] = '=';
            //twoDimensionArray[14, 10] = '=';
            //twoDimensionArray[14, 9] = '=';
            //twoDimensionArray[14, 8] = '=';
            //twoDimensionArray[14, 7] = '=';
            //twoDimensionArray[14, 6] = '=';
            //twoDimensionArray[14, 5] = '=';
            //twoDimensionArray[14, 4] = '=';
            //twoDimensionArray[14, 3] = '=';
            //twoDimensionArray[14, 2] = '=';
            //twoDimensionArray[14, 1] = '=';



            //for (int x = 0; x < twoDimensionArray.GetLength(0); x++)
            //{
            //    //Console.WriteLine(" ");
            //    for (int y = 0; y < twoDimensionArray.GetLength(0); y++)
            //    {
            //        //Console.Write("  ");
            //        //Console.Write(" ");
            //        Console.Write(twoDimensionArray[x, y]);
            //    }
            //    Console.WriteLine(); // Utan denna tomma blir allting i en enda rad 

            //}

            // _ = gameWorld[5, 9];

            //   [0, 0] = '-'
            //   [1, 0]
            //   [2, 0]
            //   [3, 0]
            //   [4, 0]
            //   [5, 0]
            //   [6, 0]
            //   [7, 0]
            //   [8, 0]
            //   [9, 0]



            //[, , , , , , , , , ]
            //[, , , , , , , , , ]
            //[, , , , , , , , , ]
            //[, , , , , , , , , ]
            //[, , , , , , , , , ]
            //[, , , , , , , , , ]
            //[, , , , , , , , , ]
            //[, , , , , , , , , ]
            //[, , , , , , , , , ]
            //gameWorld[9, 9] = '╝';
            //gameWorld[8, 9] = '║';
            //gameWorld[7, 9] = '║';
            //gameWorld[6, 9] = '║';
            //gameWorld[5, 9] = '║';
            //gameWorld[4, 9] = '║';
            //gameWorld[3, 9] = '║';
            //gameWorld[2, 9] = '║';
            //gameWorld[1, 9] = '║';
            //gameWorld[0, 9] = '╗';

            /////////////////////////////////////
            /////
            //gameWorld[9, 9] = '║';
            //gameWorld[9, 8] = '║';
            //gameWorld[9, 7] = '║';
            //gameWorld[9, 6] = '║';
            //gameWorld[9, 5] = '║';
            //gameWorld[9, 4] = '║';
            //gameWorld[9, 3] = '║';
            //gameWorld[9, 2] = '║';
            //gameWorld[9, 1] = '║';
            //gameWorld[9, 0] = '║';
            // gameWorld[9, 9] = '╝';
            // gameWorld[4, 6] = '╝';
    }
}
