using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLogic
{
    public class Food
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Food(int x, int y)
        {
            X = x; Y = y;
        }
        public void GenerateRandomPosition(int matrixSize)
        {
            Random random = new Random();
            X = random.Next(matrixSize - 1);
            Y = random.Next(matrixSize - 1);
        }

    }
}
