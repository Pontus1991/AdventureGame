using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SnakeKing
{
    class GameLogic
    {
        bool gameStatus = true;
        Snake snakeKun;
        public void GeneratePlayer()
        {
            snakeKun = new Snake(1, 10, 15);
        }
        public void RunGame()
        {
            //Console.WriteLine($"\nSnakeKun.X: {snakeKun.X} SnakeKun.Y:{snakeKun.Y}");
            //Console.WriteLine($"\nBufferWidth: {Console.BufferWidth} BufferHeight:{Console.BufferHeight}");
            Console.SetCursorPosition(5, 5);

            do
            {

                

            } while (gameStatus);

        }
        // Behöver en loop som körs oberoende om man gör nånting eller inte... ThreadSleep
        // Behöver separear switch-casen. Den gör nu 2 olika saker. 


        public void GenerateMap()
        {
            WorldMap worldMap = new WorldMap();//Kan själva bestämma X och Y.
            worldMap.NewMap();
        }

        public void GenerateApple()
        {

        }
        public void SpawnNewApples()
        {

        }
        public void SnakeMeetsWallOrApple()
        {
            //If playeyPos == MapWallPos => End game
        }

        //public void MoveLogic()
        //{
        //    keyInfo = new ConsoleKeyInfo();
        //    consoleKey = new ConsoleKey();

        //    if (X[0] == fruitX)
        //    {
        //        if (Y[0] == fruitY)
        //        {
        //            //Här addar vi på listan som är vår "snake" Det är en int lista, ++ eller Add.()?
        //            score += 100;
        //            //Score(); Anropa??
        //            //GenerateApple(X,Y);
        //        }
        //    }
        //    switch (consoleKey)
        //    {
        //        case ConsoleKey.W:
        //            Shift();
        //            Y[0]--;
        //            break;
        //        case ConsoleKey.S:
        //            Shift();
        //            Y[0]++;
        //            break;
        //        case ConsoleKey.A:
        //            Shift();
        //            X[0]--;
        //            break;
        //        case ConsoleKey.D:
        //            Shift();
        //            X[0]++;
        //            break;

        //        default:
        //            break;
        //    }

        //}
        //public void Shift()
        //{
        //    for (int i = parts + 1; i > 1; i--)
        //    {
        //        X[i - 1] = X[i - 2];
        //        Y[i - 1] = Y[i - 2];
        //    }
        //}

    }
}
