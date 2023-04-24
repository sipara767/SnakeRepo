

namespace SnakeLogic
{
    public class Segment
    {
        private int x;
        private int y;

        public int X
        {
            get => x; set
            {
                if (x == value) return;
                if (value < 0)
                    throw new InvalidSegmentValueException("the value has to be greater or equal 0");
                x = value;
            }
        }

        public int Y
        {
            get => y; set
            { 
                if (x == value) return;
                if (value< 0)
                throw new InvalidSegmentValueException("the value has to be greater or equal 0");
                y = value;
            }
        }
        public Segment(int x, int y)
        {
            X = x; Y = y;
        }
    }
}
