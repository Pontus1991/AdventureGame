using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeKing
{
    class Apple : Entity
    {
        public int Value { get; set; }
        public Apple(int value)
        {
            Value = value;
        }
    }
}
