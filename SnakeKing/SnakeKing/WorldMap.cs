using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeKing
{
    class WorldMap
    {
        //Ifall vi inte får detta att fungera i metodanropet i RunGame, skapa bara WorldMap i RunGame. -> Kopiera helst den koden då
        public int WidthX { get; set; }
        public int LengthY { get; set; }
        

        public WorldMap(int widthX, int lengthY)
        {
            WidthX = widthX;
            LengthY = lengthY;
            
        }
        public WorldMap()
        {
            WidthX = 64;
            LengthY = 44;
            
        }


        public void NewMap()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("╔");
            Console.SetCursorPosition((WidthX + 1), 0);
            Console.Write("╗");

            for (int i = 1; i < WidthX; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("═");
            }
         

        }
        

        //║ ╔ ╗╚╝═

    }
}
