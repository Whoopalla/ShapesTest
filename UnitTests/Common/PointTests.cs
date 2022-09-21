using Shapes.Common;
using Xunit;

namespace UnitTests.Common {
    public class PointTests {
        [Fact]
        public void SamePointEqualsTrue() {
            Point point = new Point(0, 0);
            Point point2 = new Point(0, 0);

            var actualAreEqual = point.Equals(point2);
            var expected = true;

            Assert.Equal(expected, actualAreEqual);
        }

        [Fact]
        public void SamePointEqualsFalse() {
            Point point = new Point(0, 0);
            Point point2 = new Point(1, 1);

            var actualAreEqual = point.Equals(point2);
            var expected = false;

            Assert.Equal(expected, actualAreEqual);
        }

        [Fact]
        public void PointEqualOperatorTrue() {
            Point point = new Point(21, 21);
            Point point2 = new Point(21, 21);


            var actualAreEqual = point == point2;
            var expected = true;

            Assert.Equal(expected, actualAreEqual);
        }

        [Fact]
        public void PointEqualOperatorFalse() {
            Point point = new Point(0, 0);
            Point point2 = new Point(0, 1);
            Point point3 = new Point(1, 1);

            var actualAreEqual = point == point2 || point2 == point3 || point == point3;
            var expected = false;

            Assert.Equal(expected, actualAreEqual);
        }

        [Fact]
        public void PointNotEqualOperatorTrue() {
            Point point = new Point(0, 0);
            Point point2 = new Point(1, 1);

            var actualAreEqual = point != point2;
            var expected = true;

            Assert.Equal(expected, actualAreEqual);
        }

        [Fact]
        public void PointNotEqualOperatorFalse() {
            Point point = new Point(0, 0);
            Point point2 = new Point(0, 0);

            var actualAreEqual = point != point2;
            var expected = false;

            Assert.Equal(expected, actualAreEqual);
        }

        [Fact]
        public void DistanseTo() {
            Point point = new Point(0, 0);
            Point point2 = new Point(0, 15.3);

            var actual = point.DistanceTo(point2);
            var expected = 15.3;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DistanseSecondInput() {
            Point point = new Point(0, 0);
            Point point2 = new Point(0, 235.01);

            var actual = point.DistanceTo(point2);
            var expected = 235.01;

            Assert.Equal(expected, actual);
        }
    }
}
