using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    // Hur kopplar vi ihop items med item vad gäller propparna. Syntaxmässigt. ..
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

    class Egg : Item // Förbrukningsbart item
    {
        public Egg()
        {
            Attribute = "Hp";
            AttributeModifier = 25;  // Ger 25 hp
        }
    }

    class ManaPot : Item // Förbrukningsbart item
    {
        public ManaPot()
        {
            Attribute = "Mana";
            AttributeModifier = 50;  // Ger 50 mana 
        }
    }

    class SunGlasses : Item 
    {
        public SunGlasses()
        {
            Attribute = "SeeItemsOnMap";
            AttributeModifier = 10;  // Se alla items på kartan om man har glasögonen på sig. 
            // Agility har ingen inverkan på förmågor men har man agility över 10 så syns alla items på kartan. 
        }
    }
}
// skapa Shield som ärver från item. Anteckningar 