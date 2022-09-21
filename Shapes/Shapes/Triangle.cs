using Shapes.Common.Exceptions;
using Point = Shapes.Common.Point;

namespace Shapes.Shapes {
    public class Triangle : Shape {
        private Point _point1;
        private Point _point2;
        private Point _point3;
        private bool _isRight;

        public Triangle(Point point1, Point point2, Point point3) {
            _point1 = point1;
            _point2 = point2;
            _point3 = point3;
            SamePointsCheck();
            _isRight = IsTriangleRight(); // if shapes will be movable - this will not work
        }

        public bool IsRight {
            get { return _isRight; }
        }

        private bool IsTriangleRight() {
            var sides = GetSides();
            var a = sides[0];
            var b = sides[1];
            var c = sides[2];
            var hypotenuse = Math.Max(Math.Max(a, b), c);
            var catheti = sides.Where(side => side != hypotenuse).ToArray();

            if (catheti.Length != 2) {
                return false;
            }

            if (hypotenuse == Math.Sqrt(Math.Pow(catheti[0], 2) + Math.Pow(catheti[1], 2))) {
                return true;
            }
            else return false;
        }

        public override double Area() {
            var sides = GetSides();
            return Math.Round(AreaByHeronFormula(sides) * 2, MidpointRounding.AwayFromZero) / 2;
        }

        private double[] GetSides() {
            return new double[] {
                _point1.DistanceTo(_point2),
                _point2.DistanceTo(_point3),
                _point3.DistanceTo(_point1)
            };
        }

        private double AreaByHeronFormula(double[] sides) {
            var halfSum = (sides[0] + sides[1] + sides[2]) / 2;
            return Math.Sqrt(halfSum * (halfSum - sides[0]) * (halfSum - sides[1]) * (halfSum - sides[2]));
        }

        private bool SamePointsCheck() {
            if (_point1 == _point2 || _point2 == _point3 || _point1 == _point3) {
                throw new SamePointUsedByOneShapeException(new Point[] { _point1, _point2, _point3 });
            }
            return false;
        }
    }
}
