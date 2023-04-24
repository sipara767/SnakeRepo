using System.Collections.Generic;
using System.Drawing;

namespace SnakeLogic {

    public class Snake {
        public int Score { get; set; }
        public bool IsAlive { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public List<Segment> SnakeBody { get; set; }

        //
        public Snake(int x, int y)
        {
            X = x; Y = y;
            SnakeBody = new List<Segment >
            {
                new Segment(x, y)
            };

        }
       
        

        public void MoveDown()
        {
            Y++;
        }
        
        public void MoveUp()
        {
            Y--;
        }

        internal void MoveLeft()
        {
            X--;
        }

        internal void MoveRight()
        {
            X++;
        }

        public void Eat()
        {
            var newSegment = new Segment(X, Y);
            SnakeBody.Insert(0, newSegment);
            Score++;
        }

        public void RemoveTail()
        {
            SnakeBody.RemoveAt(SnakeBody.Count - 1);
        }
    }
}