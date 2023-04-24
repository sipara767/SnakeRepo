using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLogic.Tests
{
    [TestClass]
    public class SegmentTest
    {
        [TestMethod]
        public void SetOfxinSegment()
        {
            //arrange
            var segment = new Segment(1,2);
            //assert
            Assert.AreEqual(1, segment.X);
        }
        [ExpectedException(typeof(InvalidSegmentValueException))]
        [TestMethod]
        public void CallCtorWithNegativeVlauForX_ThrowExcption() 
        {
            //arrange
            var segment = new Segment(-1,2);
            //assert
            

        }
        [ExpectedException(typeof(InvalidSegmentValueException))]
        [TestMethod]
        public void CallCtorWithValidValue_ThrowExcption()
        {
            //arrange
            var segment = new Segment(1, 2);
            //act
            segment.X = -1;


        }
        [ExpectedException(typeof(InvalidSegmentValueException))]
        [TestMethod]
        public void CallCtorWithValidValueforY_ThrowExcption()
        {
            //arrange
            var segment = new Segment(1, 2);
            //act
            segment.Y = -1;
           


        }
    }
}
