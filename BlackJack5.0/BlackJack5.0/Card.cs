using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack5._0
{
    class Card
    {
        public int Value { get; set; }
        public string Type { get; set; }

        public Card(int value, string type)
        {
            Value = value;
            Type = type;
        }
        public Card(int value)
        {
            Value = value;
        }

    }
   
}
