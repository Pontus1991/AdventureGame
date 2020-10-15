using System;

namespace SnakeKing
{
    class Program
    {
        static void Main(string[] args)
        {
            GameLogic newGame = new GameLogic();
            //newGame.SimpleMap();
            newGame.GenerateMap();
            newGame.GeneratePlayer();
            newGame.RunGame();

            
 
        }
    }
}
