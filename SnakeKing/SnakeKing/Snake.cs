using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeKing
{
    class Snake : Entity
    {

        public int InitialLength { get; set; }
        public int ActualLength
        {
            get { return InitialLength + Body.Count; }
        }
        private List<Apple> Body { get; set; }

        public Snake(int intialLength, int x, int y) : base(x, y)//Förhoppningsvis skall detta fungera med att ge en korrekt position på mappen.
        {
            InitialLength = intialLength;
            Body = new List<Apple>();//Här måste vi instansiera listan. Annars blir det ExceptionNull.
            X = x;
            Y = y;
        }
        public void EatApple(Apple apple)
        {
            Body.Add(apple);
        }
        public void SetCursorPos()
        {
            //Detta måste vi kolla upp, alternativt fråga om hjälp så båda förstår.
            Console.SetCursorPosition(X, Y);
            Console.Write((char)2);
            Console.SetCursorPosition(X, Y);
        }

        public void Move()
        {
            
            //Använda sparat värde från ReadInput så och röra oss efter det.
            //while(true)
            //{

            System.Threading.Thread.Sleep(100);
            SetCursorPos();
            //if (Console.KeyAvailable)
            //{
            //    ConsoleKey command = Console.ReadKey().Key;
            //    switch (command)
            //    {
            //        case ConsoleKey.LeftArrow:
            //            Console.SetCursorPosition(X, Y);
            //            Console.WriteLine(" ");

            //        X--;
            //            break;
            //        case ConsoleKey.UpArrow:
            //            Console.SetCursorPosition(X, Y);
            //            Console.WriteLine(" ");
            //            Y = Y - 1;
            //            break;
            //        case ConsoleKey.RightArrow:
            //            Console.SetCursorPosition(X, Y);
            //            Console.WriteLine(" ");
            //            X = X + 1;
            //            break;
            //        case ConsoleKey.DownArrow:
            //            Console.SetCursorPosition(X, Y);
            //            Console.WriteLine(" ");
            //            Y = Y + 1;
            //            break;

            //        //case ConsoleKey.Spacebar://Pausa spelet
            //        //    break;

            //        default:
            //            break;
            //    }


            // }
        }
        

        public void ReadInput()
        {
            //Den här funktionen ska bara läsa input och spara den.
            //Tips för att skippa låta spelet fortsätta utan att vänta på input:
            //if (Console.KeyAvailable){}
            
            if (Console.KeyAvailable)
            {
                ConsoleKey command = Console.ReadKey().Key;
                switch (command)
                {
                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(X, Y);
                        Console.WriteLine(" ");
                        X = X - 1;

                        break;
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(X, Y);
                        Console.WriteLine(" ");
                        Y = Y - 1;
                        break;
                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(X, Y);
                        Console.WriteLine(" ");
                        X = X + 1;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(X, Y);
                        Console.WriteLine(" ");
                        Y = Y + 1;
                        break;

                    //case ConsoleKey.Spacebar://Pausa spelet
                    //    break;

                    default:
                        break;
                }
            }

        }

    }
}
