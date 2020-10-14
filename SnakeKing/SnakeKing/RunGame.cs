using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeKing
{
    class RunGame
    {
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
             *            string test = "╔═════════════════════════════════════════╗";
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
            WorldMap worldMap = new WorldMap();
            worldMap.NewMap();
        }
        public void GeneratePlayer()
        {

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


    }
}
