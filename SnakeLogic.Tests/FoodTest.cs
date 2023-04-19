using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLogic.Tests
{
    [TestClass]
    public class FoodTest
    {
        [TestMethod]
        public void CheckRandPostion_Food()
        {
            //Arrange
            Food food = new Food(4,4);
            Playground playground = new Playground(5);
            //Act
            do
            {
                food.GenerateRandomPosition(playground.Matrix.GetLength(0));
            } while (food.X == 4 || food.Y == 4);
            //Assert
            Assert.AreNotEqual(food.X, 4);
            Assert.AreNotEqual(food.Y, 4);
        }
    }
}
