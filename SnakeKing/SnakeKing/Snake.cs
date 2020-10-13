using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeKing
{
    class Snake : Entity
    {
        public int Growth { get; set; }
        public List<int> Body { get; set; }

        public Snake(int growth, List<int> body)
        {
            Growth = growth;
            Body = body;
        }
        public void EatApple()
        {
            //Anropa i RunGame, GenerateApple(), SpawnApple();
        }
        public void SetCursorPos()
        {
            //Detta måste vi kolla upp, alternativt fråga om hjälp så båda förstår.
        }
    }
}
