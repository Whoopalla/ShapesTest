using System.Runtime.Serialization;

namespace Shapes.Common.Exceptions {
    [Serializable()]
    public class SamePointUsedByOneShapeException : Exception {
        private IEnumerable<Point> _points;

        protected SamePointUsedByOneShapeException()
           : base() { }

        public SamePointUsedByOneShapeException(IEnumerable<Point> value) :
           base(String.Format("Some points share same location within one shape.", value)) {
            _points = value;
        }

        public SamePointUsedByOneShapeException(IEnumerable<Point> value, string message)
           : base(message) {
            _points = value;
        }

        public SamePointUsedByOneShapeException(IEnumerable<Point> value, string message, Exception innerException) :
           base(message, innerException) {
            _points = value;
        }

        protected SamePointUsedByOneShapeException(SerializationInfo info,
                                    StreamingContext context)
           : base(info, context) { }

        public Point[] NonPrime { get { return _points.ToArray(); } }
    }
}
