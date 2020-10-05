using Klass_till_spelkarta;
using System;

namespace AdventureGame
{
    class Program
    {        
        static void Main(string[] args)
        {        
            WorldMap map = new WorldMap();
            map.AddWalls();
            map.Draw();
            
           
            //Items WorldItems = new Items("Sunglasses", "Sword", "Shield", "Egg", "Shuriken", "Manapot", "Healthpot");
            //Player Göran = new Player(10, 5, 8);
            
        }
    }
}
            
        
    

