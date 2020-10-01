using Klass_till_spelkarta;
using System;

namespace AdventureGame
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Spelkarta spel = new Spelkarta();
            spel.spelkarta();
            Items WorldItems = new Items("Sunglasses", "Sword", "Shield", "Egg", "Shuriken", "Manapot", "Healthpot");
            Player Göran = new Player(10, 5, 8);
            
        }
    }
}
            
        
    

