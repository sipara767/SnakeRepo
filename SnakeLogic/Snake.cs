
using System.Drawing;

namespace SnakeLogic {

    public class Snake {
        public int Score { get; set; }
        public bool IsAlive { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        //public List<Point> SnakeList { get; set; }


        //Snake = new List<Point>
        // {
        //    new Point =(0,0)
        //    }

        public Snake(int x, int y)
        {
            X = x; Y = y;
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
         
    }
}