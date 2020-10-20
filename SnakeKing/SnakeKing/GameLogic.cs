using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks.Sources;

namespace SnakeKing
{
    class GameLogic
    {
        int score = 0;
        int counter = 0;
        bool gameStatus = true;
        public Random rnd = new Random();
        Snake snakeKun;
        public void GeneratePlayer()
        {
            snakeKun = new Snake(1, 15, 17);
        }
        public void RunGame()
        {
            //Console.WriteLine($"\nSnakeKun.X: {snakeKun.X} SnakeKun.Y:{snakeKun.Y}");
            //Console.WriteLine($"\nBufferWidth: {Console.BufferWidth} BufferHeight:{Console.BufferHeight}");            
            do
            {
                snakeKun.ReadInput();           
                snakeKun.Move();
                
                //skapa en method för  System.Threading.Thread.Sleep(100);där varje äpple som äts, tar bort en procentuell del av 100.
            } while (gameStatus);

        }
        // Behöver en loop som körs oberoende om man gör nånting eller inte... ThreadSleep
        // Behöver separear switch-casen. Den gör nu 2 olika saker. 


        public void GenerateMap()
        {
            WorldMap worldMap = new WorldMap(); //Kan själva bestämma X och Y.
            worldMap.NewMap();
        }

        public void GenerateApple()
        {
            Apple apple = new Apple(2, 3, 4); // Tillfälliga siffror, test
            
        }
        public void SpawnNewApples()
        {
            if (true)
            {
                GenerateApple();
            }
        }
        public void SnakeMeetsWallOrApple()
        {
            if (true)
            {
                score += 10;
            }
            //If playeyPos == MapWallPos => End game
        }
    }
}
