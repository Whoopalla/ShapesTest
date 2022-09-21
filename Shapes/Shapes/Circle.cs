using Shapes.Common;

namespace Shapes.Shapes {
    public class Circle : Shape {
        private Point _center;
        private double _radius;

        public Circle(double radius) {
            if (radius <= 0) {
                throw new ArgumentOutOfRangeException(nameof(radius));
            }
            _radius = radius;
        }

        public Circle(double radius, Point center) {
            if (radius <= 0) {
                throw new ArgumentOutOfRangeException(nameof(radius));
            }
            _center = center;
            _radius = radius;
        }

        public override double Area() {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
