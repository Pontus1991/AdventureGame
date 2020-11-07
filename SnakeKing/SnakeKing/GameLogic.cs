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

        public Random rnd2 = new Random();
        Snake snakeKun;
        
        public void GeneratePlayer()
        {
            snakeKun = new Snake(5, 15, 17);
        }
        public void RunGame()
        {
            Console.Clear(); // Sudda ut all gammal samt karta etc.. och rita om ALLT på nytt
            GenerateMap(); // La in denna för att göra allt samtidigt
            //GenerateApple();
            GeneratePlayer(); // La in denna för att göra allt samtidigt
            snakeKun.ritaApple();
           
            


            //Console.WriteLine($"\nSnakeKun.X: {snakeKun.X} SnakeKun.Y:{snakeKun.Y}");
            //Console.WriteLine($"\nBufferWidth: {Console.BufferWidth} BufferHeight:{Console.BufferHeight}");            
            do
            {
                snakeKun.ReadInput();
               // snakeKun.paintApple(rnd2, out ,  out 6);
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

        //public void GenerateApple() // 
        //{
           
        //    Console.SetCursorPosition(15, 15);
        //    Console.Write(apple);
        //}
       

        public void SnakeMeetsWallOrApple() // Flytta till snakeklasS? För att dens ak in i readinput. OM -Den går in i vägg ., .. . 
            // Denna för att lägga till ett nytt äppla om SNAKE är på samma position som ett äpple 
        {
            if (true)
            {
                score += 10;
            }
            //if (isWallHit)
            //{
            //    gameStatus = false;
            //    Console.SetCursorPosition(28, 20);
            //    Console.WriteLine("The snake hit the wall! You Died! ");
            //}
            //If playeyPos == MapWallPos => End game
        }
    }
}
