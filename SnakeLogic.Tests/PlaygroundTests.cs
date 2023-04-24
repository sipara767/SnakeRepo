using System.Drawing;
using System.Xml.Linq;

namespace SnakeLogic.Tests
{
    [TestClass]
    public class PlaygroundTests
    {

        [TestMethod]
        public void InitializePlayground_WithMatrixSize5_MatricShouldbeValid()
        {
            //arrange
            var playground = new Playground(5);
            //act
            //assert
            for (int y = 0;y < playground.Matrix.Rank; y++) {
                Assert.AreEqual(5, playground.Matrix.GetLength(y));
            }
        }

        [TestMethod]
        public void MiniGame()
        {
            //Arrange
            var playground = new Playground(5);
            playground.Direction = Directions.Right;
            playground.StartGame();
            playground.Simulate();
            Thread.Sleep(10000);

        }

        [TestMethod]
        public void MoveSnakeRightWhenDirectionIsSetToRight()
        {
            //Arrange
            var playground = new Playground(5);
            playground.Direction = Directions.Right;
            playground.StartGame();
            //act
            playground.MoveSnake();
            //assert
            Assert.AreEqual(1, playground.Snake.X);
            Assert.AreEqual(0, playground.Snake.Y);
        }
        [TestMethod]
        public void SnakeEatsFoodWhenSnakeMovesOnSameXY()
        {
            //Arrange
            var playground = new Playground(5);
            playground.Direction = Directions.Right;
            playground.StartGame();
            playground.Food.X = 1;
            playground.Food.Y = 0;
            //Act
            playground.MoveSnake();
            //Assert
            Assert.IsTrue(playground.IsSnakeEatingFood());

        }
        [TestMethod]
        public void SnakeGrow_whenEatFood()
        {
            //Arrange
            var playground = new Playground(5);
            playground.Direction = Directions.Right;
            playground.StartGame();

            
            //act
            playground.MoveSnake();
            
            //Assert

            Assert.AreEqual(1, playground.Snake.SnakeBody.Count);
            
        }
        [TestMethod]
        public void SnakeDiesWhenHittingWall()
        {
            //Arrange
            var playground = new Playground(5);
            playground.Direction = Directions.Right;
            playground.Snake = new Snake(0, 4);
            playground.StartGame();

            
            // Act
            playground.MoveSnake();

            // Assert
            Assert.IsFalse(playground.Snake.IsAlive);
        }
    }
}
