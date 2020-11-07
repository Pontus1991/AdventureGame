using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace SnakeKing
{
    class Snake : Entity
    {
        string dir = "RIGHT"; // Ormen åker åt höger när den spawnar
        string pre_dir = "";
        int score = 0;

        int[] xPosition = new int[50];

        int[] yPosition = new int[50];
        int[] TailX = new int[100];
        int[] TailY = new int[100];
        int headX;
        int headY;
        int fruitX;
        int fruitY;
        int applesEaten = 0;
        bool isWallHit = false;
        bool isAppleEaten = false;
        bool isprinted;

        public Random rnd = new Random();
        public ConsoleKeyInfo keypress = new ConsoleKeyInfo();
        public int InitialLength { get; set; }
        public int ActualLength
        {
            get { return InitialLength + Body.Count; }
        }
        public List<Apple> Body_ { get; set; }
        public List<int> Body = new List<int>();
        Apple apple = new Apple(3, 2, 4); // Tillfälliga siffror, test 


        public Snake(int intialLength, int x, int y) : base(x, y)//Förhoppningsvis skall detta fungera med att ge en korrekt position på mappen.
        {
            InitialLength = intialLength;
            //Body = new List<int>();
            Body_ = new List<Apple>();//Här måste vi instansiera listan. Annars blir det ExceptionNull.
            X = x;
            Y = y;
        }
        public bool DidSnakeHitWall(int xPos, int yPos) // Gör en did snake hit apple också ??????                                              
        // Om vi gör en till så måste ett äpple spawnas igen så att det alltid är X antal äpplen på banan. 
        {
            X = xPos;
            Y = yPos;
            if (xPos == 0 || xPos == 54 || yPos == 0 || yPos == 24) return true; return false;
        }

        public bool DidSnakeHitApple(int xPos, int yPos, int x, int y) // Upptäck om ett äpple har ätits/träffats 
        {
            x = X;
            y = Y;

            applesEaten++;

            // Öka bodyn
            if (xPos == fruitX && yPos == fruitY) return true; return false;
        }

        public void SpawnNewApples()
        {
            if (true)
            {
                //GenerateApple();
            }
        }

        public void paintApple(int appleXDim, int appleYDim) // Satte ihop hans två stycken till en metod samt ändra våra två till DENNA. . . .
        {
            //X = rnd.Next(0 + 2, 54 - 2);
            //Y = rnd.Next(0 + 2, 25 - 2);

            Console.SetCursorPosition(appleXDim, appleYDim);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write((char)64);
        }

        public void setApplePositionOnScreen(Random rnd, out int appleX, out int appleY)
        {

            appleX = rnd.Next(0 + 2, 54 - 2);
            appleY = rnd.Next(0 + 2, 25 - 2);
        }

        public void ritaApple() // Denna metod för att kunna löägga utanför loopen OCH OM man äter äpple så finns metod i readinput för att lägga ut ETT nytt. 
        {
            setApplePositionOnScreen(rnd, out fruitX, out fruitY);
            paintApple(fruitX, fruitY);
        }


        //public void EatApple(Apple apple) // Öka scoren om man äter äpple. 
        //{          
        //   // System.Threading.Thread.Sleep(gamespeed + 654541)
        //}

        public void SetCursorPos()
        {
            //Detta måste vi kolla upp, alternativt fråga om hjälp så båda förstår.
            Console.SetCursorPosition(X, Y);
            Console.Write(('■')); // _Rita huvudet
            Console.SetCursorPosition(X, Y);
        }

        public void paintSnake(int applesEaten, int[] xPositionIn, int[] yPositionIn)
        {
            //xPosition[0]= 35;
            //yPosition[0] = 20;
            //Console.SetCursorPosition(X, Y);
            //Console.WriteLine(('■')); // _rita huvudet
            //console.setcursorposition(x, y);
            SetCursorPos();
            //detta måste vi kolla upp, alternativt fråga om hjälp så båda förstår.
            //console.setcursorposition(xin[0], yin[0]);
            // console.setcursorposition(x, y);

            // rita kroppen...
            for (int i = 1; i <= applesEaten + 1; i++)
            {
                Console.SetCursorPosition(xPositionIn[i], yPositionIn[i]);
                Console.Write(('o'));
            }

            // Erase the last part of the snake. 

            Console.SetCursorPosition(xPositionIn[applesEaten + 1], yPositionIn[applesEaten + 1]);
            Console.WriteLine(" ");

            // Record location of each body part. 

            //for (int i = applesEaten+1; i > 0; i--)
            //{
            //    xPositionIn[i] = xPositionIn[i - 1];
            //    yPositionIn[i] = yPositionIn[i - 1];
            //}

            // Return the new array

            //xPositionout = xPositionIn;
            //yPositionout = yPositionIn;
        }


        public void ReadInput()
        {
            //paintSnake(applesEaten, xPosition, yPosition, out xPosition, out yPosition);
            //Den här funktionen ska bara läsa input och spara den.
            //Tips för att skippa låta spelet fortsätta utan att vänta på input:
            //if (Console.KeyAvailable){}
            isWallHit = DidSnakeHitWall(X, Y); // Lägg in så att datorn märker om ormen är på samma position som ramen. 
            isAppleEaten = DidSnakeHitApple(X, Y, fruitX, fruitY);

            // Issnakeapple?????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????
            if (isWallHit)
            {
                //  gamestatus = false;
                Console.SetCursorPosition(20, 25); // Vart ska texten som skrivs ut synas!! ?? !! 
                // Texten är direkt under ramen just nu 
                Console.WriteLine("the snake hit the wall! you died! ");
                Console.SetCursorPosition(20, 26);
                Console.WriteLine("Spelet kommer nu att börja om.");
                System.Threading.Thread.Sleep(2000);
                GameLogic gameLogic = new GameLogic();
                gameLogic.RunGame(); // Kör spelet igen 
                // Blinka till några gånger med denna system threaD? ? 
                // Kom tillbaka till huvudmenyn i början med metod. 
            }

            if (isAppleEaten) // Vi vill BARA sätta ut nytt äpple när ett har ätits. Lägg alltså intei loop för då spawnar massa. 
            {
                // Body.Add(apple);
               
                ritaApple();
                Body_.Add(apple);

                //SetCursorPos();
                //for (int k = 0; k < nTail; k++)
                //{
                //    Console.Write("o");
                //    isPrinted = true;
                //}
                //if (!isPrinted)
                //{
                //    Console.Write(" ");
                //}

                // Öka score... Struckt ?
                //setApplePositionOnScreen(rnd, out appleXDim);  // skapa nytt äpple
            }

            //setApplePositionOnScreen(rnd, out int appleX, out int appleY);
            //paintApple(appleX, appleY);
            //if playeypos == mapwallpos => end game
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
                            // paintSnake(applesEaten, xPosition, yPosition, out xPosition, out yPosition);
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

            System.Threading.Thread.Sleep(80); // "Lagg" om man har hög threading

            Console.Write(" "); // Sudda ut där man har gått 

            Console.SetCursorPosition(0, 0);

            for (int i = 0; i < Y; i++)
            {
                for (int j = 0; j < X; j++)
                {
              
                       // isprinted = false;
                        for (int k = 1; k < applesEaten; k++)
                        {
                            if (TailX[k] == j && TailY[k] == i)
                            {
                                Console.Write("o");
                                isprinted = true;
                            }
                        }
                        
                    }
                }
                Console.WriteLine();
                //foreach (var item in Body_)
                //{
                //    Console.Write('o');
                //    Console.WriteLine(" "); // Sudda ut där man har gått. (BLIR varannan nu) 
                //}


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
