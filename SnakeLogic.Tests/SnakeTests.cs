
namespace SnakeLogic.Tests
{
    [TestClass]
    public class SnakeTests
    {
        [TestMethod]
        public void SnakeMovesUp_Y_HasDecreased() {
            //arrange
            var snake = new Snake (1,1);
            //act
            snake.MoveUp();
            //assert
            Assert.AreEqual(1, snake.X);
            Assert.AreEqual(0, snake.Y);
        }
        [TestMethod]
        public void SnakeMovesDown_Y_HasIncreased()
        {
            //arrange
            var snake = new Snake (1,1);
            //act
            snake.MoveDown();
            //assert
            Assert.AreEqual(1, snake.X);
            Assert.AreEqual(2, snake.Y);
        }
    }
}
