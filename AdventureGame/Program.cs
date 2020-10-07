
using System;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game p = new Game();
            p.DrawWall();
            p.RunGameLoop();
            p.WritePlayer('X', 1, 1);
        }
    }
}
            
        
    

