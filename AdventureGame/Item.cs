using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    abstract class Item  
    {
        public int AttributeModifier { get; set; }
        public string Attribute { get; set; }
    }

    class Shield : Item
    {
        public Shield()
        {
            Attribute = "hp";
            AttributeModifier = 20;  // Hur mycket ska skölden ge...
        }
        
        
        

    }


}
// skapa Shield som ärver från item. 