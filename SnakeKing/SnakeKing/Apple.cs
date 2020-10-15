using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeKing
{
    class Apple : Entity
    {
        public int Value { get; set; }
        public Apple(int value, int x, int y) :base(x, y) //Här kan vi använda widthX och heightY i en random function.
        {
            Value = value;
            X = x;
            Y = y;
        }
    }
}
