using System.Runtime.Serialization;

namespace SnakeLogic
{
    [Serializable]
    public class InvalidSegmentValueException : Exception
    {
        public InvalidSegmentValueException()
        {
        }

        public InvalidSegmentValueException(string? message) : base(message)
        {
        }

        public InvalidSegmentValueException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidSegmentValueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}