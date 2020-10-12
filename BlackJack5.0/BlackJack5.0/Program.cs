using System;

namespace BlackJack5._0
{
    class Program
    {
        static void Main(string[] args)
        {
            RunGame newGame = new RunGame();
            newGame.GameLogic();
            //newGame.CreateCardDeck();
            ////newGame.CreateCardDeck();
            ////newGame.CreateCardDeck();
            ////newGame.CreateCardDeck();
            //newGame.Meny();

            Console.ReadLine();
        }
    }
}
