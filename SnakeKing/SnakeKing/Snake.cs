using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace SnakeKing
{
    class Snake : Entity
    {
        string dir = "RIGHT";
        string pre_dir = "";
        public ConsoleKeyInfo keypress = new ConsoleKeyInfo();
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
            Console.Write(('■'));
            Console.SetCursorPosition(X, Y);
        }

        public void ReadInput()
        {
            //Den här funktionen ska bara läsa input och spara den.
            //Tips för att skippa låta spelet fortsätta utan att vänta på input:
            //if (Console.KeyAvailable){}

            while (Console.KeyAvailable)
            {
                // ConsoleKey command = Console.ReadKey().Key;
                keypress = Console.ReadKey(true);
                if (keypress.Key == ConsoleKey.LeftArrow)
                {
                    pre_dir = dir;
                    dir = "LEFT";
                }
                else if (keypress.Key == ConsoleKey.RightArrow)
                {
                    pre_dir = dir;
                    dir = "RIGHT";
                }
                else if (keypress.Key == ConsoleKey.UpArrow)
                {
                    pre_dir = dir;
                    dir = "UP";
                }
                else if (keypress.Key == ConsoleKey.DownArrow)
                {
                    pre_dir = dir;
                    dir = "DOWN";
                }
            }
        }

        public void Move()
        {
            //Använda sparat värde från ReadInput så och röra oss efter det.
            //while(true)
            //{
            
            SetCursorPos(); // Böt plats på denna och threading. 
           
            switch (dir)
            {
                case "RIGHT":
                    X++;
                    break;
                case "LEFT":
                    X--;
                    break;
                case "UP":
                    Y--;
                    break;
                case "DOWN":
                    Y++;
                    break;
                default:
                    break;
            }
            System.Threading.Thread.Sleep(100); // Lagg om man har hög threading
           
            
        }
    }
}

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


//switch (command)
//{
//    case ConsoleKey.LeftArrow:
//        Console.SetCursorPosition(X, Y);
//       // Console.WriteLine(" ");
//        // X = X - 1;
//        X--;
//        break;
//    case ConsoleKey.UpArrow:
//        Console.SetCursorPosition(X, Y);
//        //Console.WriteLine(" ");
//        // Y = Y - 1;
//        Y--;
//        break;
//    case ConsoleKey.RightArrow:
//        Console.SetCursorPosition(X, Y);
//       // Console.WriteLine(" ");
//        // X = X + 1;
//        X++;
//        break;
//    case ConsoleKey.DownArrow:
//        Console.SetCursorPosition(X, Y);
//       // Console.WriteLine(" ");
//        Y++;
//       // Y = Y + 1;
//        break;

//    //case ConsoleKey.Spacebar://Pausa spelet
//    //    break;

//    default:
//        break;

//}
