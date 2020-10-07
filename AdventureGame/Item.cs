using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AdventureGame
{
    // Hur kopplar vi ihop items med item vad gäller propparna. Syntaxmässigt. ..
    abstract class Item  
    {
        public string Sword { get; set; }
        public string Shield { get; set; }
        public string Shuriken { get; set; }
        public string ManaPotion { get; set; }
        public string HealthPotion { get; set; }
        public int AttributeModifier { get; set; }
        public string Attribute { get; set; }
    }

  

    class Shield : Item
    {
        public Shield(string shield, int attributeModifier, string attribute)
        {
            Shield = shield;
            Attribute = attribute;
            AttributeModifier = attributeModifier;
        }
    }

    class Sword : Item
    {
        public Sword()
        {
            Attribute = "Damage";
            AttributeModifier = 10;  // Hur mycket skadar svärdet
        }
    }

    class Shuriken : Item // Förbrukningsbart item
    {
        public Shuriken()
        {
            Attribute = "Damage";
            AttributeModifier = 30;  // Skadar 30 
        }
    }

    class HealPot : Item // Förbrukningsbart item
    {
        public HealPot()
        {
            Attribute = "Hp";
            AttributeModifier = 50;  // Ger 50 hp
        }
    }

    class ManaPot : Item // Förbrukningsbart item
    {
        public ManaPot(string manaPot,int attributeModifier, string attribute)
        {
            ManaPotion = manaPot;
            AttributeModifier = attributeModifier;
            Attribute = attribute;
            
            
        }
    }
}
