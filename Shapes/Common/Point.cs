namespace Shapes.Common {
    public struct Point {
        private double x;
        private double y;

        public Point(double x, double y) {
            this.x = x;
            this.y = y;
        }

        public double GetX() {
            return x;
        }

        public double GetY() {
            return y;
        }

        public double DistanceTo(Point p) {
            return Math.Sqrt(Math.Pow(this.x - p.GetX(), 2.0) + Math.Pow(this.y - p.GetY(), 2.0));
        }

        public override bool Equals(object obj) {
            if (obj == null || obj is not Point) {
                return false;
            }
            Point point = (Point)obj;
            if (point.x == x && point.y == y) {
                return true;
            }
            return false;
        }

        public override int GetHashCode() {
            return x.GetHashCode() ^ y.GetHashCode();
        }

        public static bool operator ==(Point a, Point b) {
            if (a.x == b.x && a.y == b.y) {
                return true;
            }
            return false;
        }
        public static bool operator !=(Point a, Point b) {
            return !(a == b);
        }
    }
}
