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

        public Snake(int intialLength, int x, int y) :base(x, y)//Förhoppningsvis skall detta fungera med att ge en korrekt position på mappen.
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
        }
    }
}
