using System;

namespace SnakeKing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            GameLogic newGame = new GameLogic();
            //newGame.SimpleMap();
            newGame.RunGame();

        }
    }
}
