
using System.Diagnostics;
using System.Drawing;
using System.Timers;

namespace SnakeLogic
{
    public class Playground {
        public bool[,] Matrix { get; set; }
        public Directions Direction { get; set; }
        public Snake Snake { get; set; }
        public Food Food { get; set; }
        public bool gameOver { get; set; }

        public Playground(int matrixSize)
        {
            Matrix = new bool[matrixSize, matrixSize];

        }
        // 
        public void PlaceSnakeInEnvironment(Snake snake)
        {

            Matrix[snake.X, snake.Y] = true;
            foreach (Segment segment in snake.SnakeBody)
            {
                Matrix[segment.X, segment.Y] = true;
            }
        }
        public void PlaceFoodInEnvironment(Food food)
        {
            do
            {
                food.GenerateRandomPosition(Matrix.GetLength(0));
            } while (food.X == Snake.X || food.Y == Snake.Y);
            Matrix[food.X, food.Y] = true;

        }
        //
        public bool IsSnakeEatingFood()
        {
            if (Snake.X == Food.X && Snake.Y == Food.Y)
            {

                Snake.Eat();
                return true;
            }
            else
            {
                return false;
            }
        }


        public void MoveSnake()
        {

            if (Direction == Directions.Up)
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
            if (Snake.X < 0 || Snake.Y < 0 || Snake.X >= Matrix.GetLength(0) || Snake.Y >= Matrix.GetLength(1))
            {
                EndGame();
            }
        }

        public void StartGame()
        {
            Snake = new Snake(0, 0);
            Food = new Food(1, 0);
            Direction = Directions.Right;
            PlaceSnakeInEnvironment(Snake);
            PlaceFoodInEnvironment(Food);
        }
        //
        public void Simulate()
        {
            while (!gameOver)
            {
                MoveSnake();

                if (!Snake.IsAlive)
                {
                    EndGame();
                    break;
                }


                if (IsSnakeEatingFood())
                {
                    Snake.Score++;
                    PlaceFoodInEnvironment(Food);


                }
                else
                {
                    Snake.RemoveTail();
                }
                MoveSnake();
                Direction = Directions.Down;
                MoveSnake();
                MoveSnake();
                Direction = Directions.Right;
                MoveSnake();
                MoveSnake();

            }
            //"
        }
        public void EndGame()
        {
            Console.WriteLine("Game over! Your score is " + Snake.Score);
            // Reset the game
            StartGame();
            gameOver = false;
        }
    }
}