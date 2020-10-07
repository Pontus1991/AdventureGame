using Klass_till_spelkarta;
using System;

namespace AdventureGame
{
    class Program
    {        
        static void Main(string[] args)
        {
            WorldMap p = new WorldMap();
            p.DrawWall();
            p.RunGameLoop();
            p.WritePlayer('X', 1, 1);


            //Items WorldItems = new Items("Sunglasses", "Sword", "Shield", "Egg", "Shuriken", "Manapot", "Healthpot");
            //Player Göran = new Player(10, 5, 8);

        }
    }
}
            
        
    

