﻿using System;

namespace BlackJack5._0
{
    class Program
    {
        static void Main(string[] args)
        {
            RunGame newGame = new RunGame();
            newGame.CreateCardDeck();
            ////newGame.CreateCardDeck();
            ////newGame.CreateCardDeck();
            ////newGame.CreateCardDeck();
            newGame.Meny();

            Console.ReadLine();
        }
    }
}
