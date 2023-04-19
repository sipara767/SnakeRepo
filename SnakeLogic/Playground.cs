
using System.Diagnostics;
using System.Timers;

namespace SnakeLogic
{
    public class Playground {
        public bool[,] Matrix { get; set; }
        public Directions Direction { get; set; }
        public Snake Snake { get; set; }
        public Food Food { get; set; }

        public Playground(int matrixSize)
        {
            Matrix = new bool[matrixSize, matrixSize];
           
        }
                //>
        public void PlaceSnakeInEnvironment(Snake snake) {
            Matrix[snake.X, snake.Y] = true;
            //for (int  i = 1;  i < snake.score + 1;  i++)
            //{
            //    if (direction == directions.right)
            //    {
            //        //matrix[snake.x - i, snake.y];
            //    }
            //}
        }
        public void PlaceFoodInEnvironment(Food food)
        {
            do
            {
                food.GenerateRandomPosition(Matrix.GetLength(0));
            } while (food.X == Snake.X || food.Y == Snake.Y);
            Matrix[food.X, food.Y] = true;
           
        }
        public bool IsSnakeEatingFood()
        {
            if (Snake.X == Food.X && Snake.Y == Food.Y)
            { 
                //Snake.Score++;
                //PlaceFoodInEnvironment(Food);
                return true;
            }
            else
            {
                return false;
            }
        }


        public void MoveSnake()
        {
            if(Direction == Directions.Up)
            {
                Snake.MoveUp();
            }
            if (Direction == Directions.Down)
            {
                Snake.MoveDown();
            }
            if (Direction == Directions.Left)
            {
                Snake.MoveLeft();
            }
            if (Direction == Directions.Right)
            {
                Snake.MoveRight();
            }
        }

        public void StartGame()
        {
            Snake = new Snake(0,0);
            Food = new Food(1,0);
            Direction = Directions.Right;
            PlaceSnakeInEnvironment(Snake);
            PlaceFoodInEnvironment(Food);
        }

        public void Simulate() 
        {

            MoveSnake();
            if(IsSnakeEatingFood())
            {
                Snake.Score++;
                PlaceFoodInEnvironment(Food);
                //snake size increase
            }
            MoveSnake();
            Direction = Directions.Down;
            MoveSnake();
            MoveSnake();
            Direction = Directions.Right;
            MoveSnake();
            MoveSnake();
       
        }

    }
}