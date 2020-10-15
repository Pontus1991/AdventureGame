using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeKing
{
    abstract class Entity
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Entity(int x, int y)
        {

        }
        public Entity()
        {

        }
    }
}
