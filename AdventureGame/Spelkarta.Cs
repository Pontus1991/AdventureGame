using System;
using System.Collections.Generic;
using System.Text;

namespace Klass_till_spelkarta
{
    class Spelkarta
    {
        /// <summary>
        /// //  VAD är widht och VAD är height i loopen???  
        /// Så fort vi ändrar till widht elelr heright spå blir det out of range. 
        /// </summary>
        //
        //int redo = 0;
        //int sides = 20;
        //ConsoleKeyInfo Keyinfo;

        //const int width = 30;
        //const int height = 30;
        
        //char[,] gameWorld = new char[width, height];


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


        //Nikola -> Har fortfarande problem när jag kör solution i main, får ett C

        //public void spelkarta()
        //{
        //    for (int x = 0; x < width; x++)
        //    {
        //        for (int y = 0; y < height; y++)
        //        {
        //            Console.Write(gameWorld[x, y]); // Skriver ut ramen. 
        //        }

        //        Console.WriteLine();
        //    }
        //}


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





















    

