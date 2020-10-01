using System;
using System.Collections.Generic;
using System.Text;

namespace Klass_till_spelkarta
{
    class Spelkarta
    {
        int redo = 0;
        int sides = 20;
        ConsoleKeyInfo Keyinfo;

        const int width = 30;
        const int height = 30;

        public void spelkarta()
        {
            var gameWorld = new char[width, height];

            for (int x = 0; x < 29; x++)
            {
                gameWorld[x, 0] = '║';  // kod till väggen till vänster 
                gameWorld[28, x] = '═'; // kod till "golvet"

                for (int y = 0; y < height; y++)
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
        }


        //if (playerBox.Intersects(meteorBox)) 
        //{
        //    //Vi har en kollision här!
        //}
        // IntersectsWith
        //do
        //{
        //    spelkarta();
        //    Keyinfo = Console.ReadKey(true);
        //    Console.Clear();

        //    switch (Keyinfo.Key)
        //    {
        //        case ConsoleKey.RightArrow:
        //            sides++;
        //            Console.SetCursorPosition(sides, 10);
        //            Console.Write("X");
        //            break;
        //        case ConsoleKey.LeftArrow:
        //            sides--;
        //            Console.SetCursorPosition(sides, 10);
        //            Console.Write("X");
        //            break;
        //        case ConsoleKey.UpArrow:
        //            redo++;
        //            Console.SetCursorPosition(sides, 10);
        //            Console.Write("X");
        //            break;
        //        case ConsoleKey.DownArrow:
        //            redo--;
        //            Console.SetCursorPosition(sides, 10);
        //            Console.Write("X");
        //            break;
        //    }
        //    } while (redo == 0);
        //    Console.ReadLine();





















    }
}
