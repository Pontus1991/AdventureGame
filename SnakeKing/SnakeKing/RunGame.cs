using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SnakeKing
{
    class RunGame
    {
        int parts = 0;
        int score = 0;
        int[] X;
        int[] Y;
        int fruitX;
        int fruitY;
        ConsoleKeyInfo keyInfo;
        ConsoleKey consoleKey;

        
        public void SimpleMap()
        {
            // ║ ╔ ╗╚╝═
            //Console.WriteLine("╔═════════════════════════════════════════╗");
            //Console.WriteLine("║                                         ║");
            //Console.WriteLine("║                                         ║");
            //Console.WriteLine("║                                         ║");
            //Console.WriteLine("║                                         ║");
            //Console.WriteLine("║                                         ║");
            //Console.WriteLine("║                                         ║");
            //Console.WriteLine("║                                         ║");
            //Console.WriteLine("║                                         ║");
            //Console.WriteLine("║                                         ║");
            //Console.WriteLine("║                                         ║");
            //Console.WriteLine("║                                         ║");
            //Console.WriteLine("║                                         ║");
            //Console.WriteLine("║                                         ║");
            //Console.WriteLine("║                                         ║");
            //Console.WriteLine("║                                         ║");
            //Console.WriteLine("║                                         ║");
            //Console.WriteLine("║                                         ║");
            //Console.WriteLine("╚═════════════════════════════════════════╝");

            

            /*
             *string test = "╔═════════════════════════════════════════╗";
              char[] taket = test.ToCharArray();
              string golv1Test = "╚═════════════════════════════════════════╝";
              var golvet = golv1Test.ToCharArray();
              taket = test.ToCharArray();
            
            foreach (var item in taket)
            {
                Console.Write(item);
            }
            foreach (var item in golvet)
            {
                Console.Write(item);
            }
             */


        }
        public void GenerateMap()
        {
            WorldMap worldMap = new WorldMap();//Kan själva bestämma X och Y.
            worldMap.NewMap();
        }
        public void GeneratePlayer()
        {
            Snake snakeKun = new Snake(5,);
        }
        public void GenerateApple()
        {

        }
        public void SpawnNewApples()
        {

        }
        public void CrawlableSpace()
        {
            //If playeyPos == MapWallPos => End game
        }

        public void MoveLogic()
        {
            keyInfo = new ConsoleKeyInfo();
            consoleKey = new ConsoleKey();

            if (X[0] == fruitX)
            {
                if (Y[0] == fruitY)
                {
                    //Här addar vi på listan som är vår "snake" Det är en int lista, ++ eller Add.()?
                    score += 100;
                    //Score(); Anropa??
                    //GenerateApple(X,Y);
                }
            }
            switch (consoleKey)
            {
                case ConsoleKey.W:
                    Shift();
                    Y[0]--;
                    break;
                case ConsoleKey.S:
                    Shift();
                    Y[0]++;
                    break;
                case ConsoleKey.A:
                    Shift();
                    X[0]--;
                    break;
                case ConsoleKey.D:
                    Shift();
                    X[0]++;
                    break;

                default:
                    break;
            }
            
        }
        public void Shift()
        {
            for (int i = parts + 1; i > 1; i--)
            {
                X[i - 1] = X[i - 2];
                Y[i - 1] = Y[i - 2];
            }
        }
        
    }
}
