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
        public char[,] MapEdge { get; set; }

        public WorldMap(int widthX, int lengthY, char[,] mapEdge)
        {
            WidthX = widthX;
            LengthY = lengthY;
            MapEdge = mapEdge;
        }
    }
}
