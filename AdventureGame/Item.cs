namespace AdventureGame
{
 
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
        public Sword(string sword, int attributeModifier, string attribute)
        {
            Sword = sword;
            AttributeModifier = attributeModifier;
            Attribute = attribute;
            
        }
    }

    class Shuriken : Item
    {
        public Shuriken(string shuriken, int attributeModifier, string attribute)
        {
            Shuriken = shuriken;
            AttributeModifier = attributeModifier;
            Attribute = attribute;
        }
    }

    class HealPot : Item 
    {
        public HealPot(string healPot, int attributeModifier, string attribute)
        {
            HealthPotion = healPot;
            AttributeModifier = attributeModifier;
            Attribute = attribute;
        }
    }

    class ManaPot : Item
    {
        public ManaPot(string manaPot,int attributeModifier, string attribute)
        {
            ManaPotion = manaPot;
            AttributeModifier = attributeModifier;
            Attribute = attribute;
            
            
        }
    }
}
