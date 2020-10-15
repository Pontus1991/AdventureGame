using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeKing
{
    class WorldMap
    {
        //Ifall vi inte får detta att fungera i metodanropet i RunGame, skapa bara WorldMap i RunGame. -> Kopiera helst den koden då
        public int WidthX { get; set; }
        public int HeightY { get; set; }

       


        public WorldMap(int widthX, int heightY)
        {
            WidthX = widthX;
            HeightY = heightY;
            
        }
        public WorldMap()
        {
            WidthX = 54;
            HeightY = 25;
        }



        public void NewMap()
        {
            for (int i = 0; i < WidthX + 1; i++) // Yttre forloop går igneom VÅGRÄTT!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("═");
            }

            for (int p = 0; p < WidthX + 1; p++)
            {
                Console.SetCursorPosition(p, HeightY -1);
                Console.Write("═");
            }

            for (int j = 0; j < HeightY -1; j++)
            {
                Console.SetCursorPosition(0, j);
                Console.Write("║");
            }

            for (int n = 0; n < HeightY -1; n++)
            {
                Console.SetCursorPosition(WidthX, n);
                Console.Write("║");
            }

            Console.SetCursorPosition(0, 0);
            Console.Write("╔");
            Console.SetCursorPosition((WidthX), 0);
            Console.Write("╗");
            Console.SetCursorPosition(0, HeightY -1);
            Console.Write("╚");
            Console.SetCursorPosition((WidthX), HeightY -1);
            Console.Write("╝");
        }
        

        //║ ╔ ╗╚╝═

    }
}
